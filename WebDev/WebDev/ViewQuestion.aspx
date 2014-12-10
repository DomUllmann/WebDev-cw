<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewQuestion.aspx.cs" Inherits="WebDev.ViewQuestion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="wrapper style1 first">
                <asp:FormView ID="crumb" runat="server" DataKeyNames="ID" 
                    ItemType="WebDev.Models.Breadcrumb" SelectMethod="GetBreadcrumbs">
                    <EmptyDataTemplate></EmptyDataTemplate>
                    <ItemTemplate>
                        You are here: <a href="Default.aspx">Home</a> -> <a href="Subject.aspx?subjectID=<%#:Item.SubjectID %>"><%#:Item.SubjectName %></a>
                        -> <a href="Module.aspx?moduleID=<%#:Item.ModuleID %>"><%#:Item.ModuleID %></a> -> Question
                    </ItemTemplate>
                </asp:FormView>
                </div>
            </div>
            </div>
    <div class="wrapper style1">
  <article class="container" id="top">
    <div class="row">
      <div class="col-lg-2"> </div>
      <div class="col-lg-8">
        <header>
            <asp:FormView ID="question" runat="server" DataKeyNames="QuestionID"
                        ItemType ="WebDev.Models.Question" SelectMethod ="GetQuestions">
                        <EmptyDataTemplate>
                            <h1><strong>Ooops! Somethings gone wrong!</strong></h1>
                            <h3>It looks like you didn't select a valid question. If you followed a link here,
                                try heading back and trying it again. If you came directly here, make sure
                                you supplied a question ID</h3>
                            </h3>
                        </EmptyDataTemplate>

                        <ItemTemplate>
                            <header>
                                <h1><strong><%#: Item.QuestionTitle %></strong></h1>
                                <h4>Asked by: <%#:Item.User %> at <%#: Item.Created %></h4>
                            </header>
                            <h5><%#:Item.QuestionBody %></h5>
                        </ItemTemplate>
                    </asp:FormView>
        </header>
      </div>
    </div>
  </article>
</div>

    <div class="wrapper style1 firstSmall">
  <article class="container" id="top">
    <div class="row">
      <div class="col-lg-2"> </div>
      <div class="col-lg-8">

        <header>
          <h1><strong>Answers</strong></h1>
        </header>
          <asp:ListView ID="answerList" runat="server"
        DataKeyNames="AnswerID" GroupItemCount="1"
        ItemType="WebDev.Models.Answer" SelectMethod="GetAnswers">
        <EmptyDataTemplate>
            <table>
                <tr>
                    <td>Hmm, looks like no ones answered this question yet!</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
            <td />
        </EmptyItemTemplate>
                <ItemTemplate>
                    
                <div class="answer">
                    <table class="table">
                    <tr><td>
                        <%#:Item.AnswerBody %> 
                    </td>
                        </tr>
                    <tr>
                        <td><weak>Answered by: <%#:Item.User %> at <%#:Item.Created %></weak></td>
                       </tr> 
                        </table>
                    </div>
                </ItemTemplate>
            
        <LayoutTemplate>
                    <table id="itemPlaceholder" runat="server"></table>
                        
        </LayoutTemplate>
    </asp:ListView>
          </div>
    </div>
  </article>
</div>
    <asp:LoginView ID="LoginView1" runat="server">
        <LoggedInTemplate>
            <asp:FormView runat="server" ID="addAnswerForm"
    ItemType="WebDev.Models.Answer" 
    InsertMethod="addAnswerForm_addItem" DefaultMode="Insert"
    RenderOuterTable="false" OnItemInserted="addStudentForm_ItemAdded">
    <InsertItemTemplate>
        <fieldset>
            <ol>
                <asp:DynamicEntity runat="server" Mode="Insert" />
            </ol>
            <asp:Button runat="server" Text="Ask a question" CommandName="Insert" />
            <asp:Button runat="server" Text="Create a document" CausesValidation="false" OnClick="cancelButton_Click" />
            <br />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>

        </LoggedInTemplate>
        <AnonymousTemplate>
            <p>Please log in to answer a question.</p>
        </AnonymousTemplate>
    </asp:LoginView>
</asp:Content>


