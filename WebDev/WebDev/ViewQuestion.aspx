<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewQuestion.aspx.cs" Inherits="WebDev.ViewQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrapper style1 first">
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
                                <h4>Asked by: <%#:Item.User %></h4>
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
        <GroupTemplate>
                     <tr id="itemPlaceholder" runat="server"></tr>
                    
                </GroupTemplate>
                <ItemTemplate>
                    <tr>
                    <td>
                        <%#:Item.AnswerBody %>
                    </td>
                        </tr>
                    <tr><br />
                        <td><weak>Answered by: <%#:Item.User %> at <%#:Item.Created %></weak></td>
                        </tr>
                </ItemTemplate>
            
        <LayoutTemplate>
                <div class="jumbotron">
                            <table id="groupPlaceholder" runat="server"></table>                        
                </div>
        </LayoutTemplate>
    </asp:ListView>
          </div>
    </div>
  </article>
</div>
</asp:Content>
