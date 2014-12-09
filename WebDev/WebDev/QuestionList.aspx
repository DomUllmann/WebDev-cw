<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QuestionList.aspx.cs" Inherits="WebDev.QuestionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
        <div class="row">
            <div class="wrapper style1 first">
                <asp:FormView ID="crumb" runat="server" DataKeyNames="ID" 
                    ItemType="WebDev.Models.Breadcrumb" SelectMethod="GetBreadcrumbs">
                    <EmptyDataTemplate></EmptyDataTemplate>
                    <ItemTemplate>
                        You are here: <a href="Default.aspx">Home</a> -> <a href="Subject.aspx?subjectID=<%#:Item.SubjectID %>"><%#:Item.SubjectName %></a>
                        -> <a href="Module.aspx?moduleID=<%#:Item.ModuleID %>"><%#:Item.ModuleID %></a> ->
                        <a href="QuestionList.aspx?moduleID="<%#:Item.ModuleID %>">Question List</a>
                    </ItemTemplate>
                </asp:FormView>
                </div>
            </div>
            </div>
     <section>
        <div class="wrapper style1 first">
          <article class="container" id="top">
            <div class="row">
              <div class="col-lg-4 image fit"><img src="/Content/images/question.jpg" alt="Here's the best place to get help!" /></div>
              <div class="col-lg-8">
                    <asp:FormView ID="module" runat="server" DataKeyNames="ModuleID"
                        ItemType ="WebDev.Models.Module" SelectMethod ="GetModules">
                        <EmptyDataTemplate>
                            <h1><strong>Ooops! Somethings gone wrong!</strong></h1>
                            <h3>It looks like you didn't select a proper module. If you followed a link here,
                                try heading back and trying it again. If you came directly here, make sure
                                you supplied a module ID</h3>
                            </h3>
                        </EmptyDataTemplate>

                        <ItemTemplate>
                            <header>
                                <h1><strong><%#: Item.ModuleID %>: <%#: Item.ModuleTitle %></strong>!</h1>
                            </header>
                            <p>Here's a list of all the questiosn for <b><%#: Item.ModuleTitle %></b>!</p>
                  <p>Here you'll find all of the questions that have been asked so far, hopefully with some really usefull answers to them! <br />
                      If your questions hasn't already been asked, why not ask a new one?
                      great answers too!</p>
                        </ItemTemplate>
                    </asp:FormView>
              </div>
            </div>
          </article>
        </div>
    </section>
    <section> 
        <div class="wrapper style1" id="meh">
                <div class="contentTable">
                    
                        <div class="noteslist">
            <div class="container">
            <div class="row">
                <h1>Questions</h1>
            <table class="table">
                        <tbody>
        <asp:ListView ID="questionList" runat="server"
        DataKeyNames="QuestionID" GroupItemCount="1"
        ItemType="WebDev.Models.Question" SelectMethod="GetQuestions">
        <EmptyDataTemplate>
            <table>
                <tr>
                    <td>Oops, something went wrong, please try again!</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td />
        </EmptyItemTemplate>
        <GroupTemplate>
                     <td id="itemPlaceholder" runat="server"></td>
                    
                </GroupTemplate>
                <ItemTemplate>
                    <tr>
                    <td>
                        <a href="ViewQuestion.aspx?questionID=<%#:Item.QuestionID%>" id="parags"><%#:Item.QuestionTitle %></a>
                    </td>
                        </tr>
                </ItemTemplate>
            
        <LayoutTemplate>
                            <tr id="groupPlaceholder" runat="server"></tr>
                        
        </LayoutTemplate>
    </asp:ListView>
                            
                            </tbody>
                    </table>
                </div>
                </div>
            </div>
                        </div>
                    </div>
    </section>
</asp:Content>
