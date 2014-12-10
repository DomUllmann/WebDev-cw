<%@ Page Title="Create a document" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateNotes.aspx.cs" Inherits="WebDev.CreateNotes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="wrapper style1 first">
                <asp:FormView ID="crumb" runat="server" DataKeyNames="ID" 
                    ItemType="WebDev.Models.Breadcrumb" SelectMethod="GetBreadcrumbs">
                    <EmptyDataTemplate></EmptyDataTemplate>
                    <ItemTemplate>
                        You are here: <a href="Default.aspx">Home</a> -> <a href="Subject.aspx?subjectID=<%#:Item.SubjectID %>"><%#:Item.SubjectName %></a>
                        -> <a href="Module.aspx?moduleID=<%#:Item.ModuleID %>"><%#:Item.ModuleID %></a> -> Notes Document
                    </ItemTemplate>
                </asp:FormView>
                </div>
        </div>
    </div>

    <div class="wrapper style1 first">
  <article class="container" id="top">
    <div class="row">
      <div class="col-lg-2"> </div>
      <div class="col-lg-8">
        <header>
            <asp:FormView ID="notes" runat="server" DataKeyNames="NotesID"
                        ItemType ="WebDev.Models.Notes" SelectMethod ="GetNotes">
                        <EmptyDataTemplate>
                            <h1><strong>Ooops! Somethings gone wrong!</strong></h1>
                            <h3>It looks like you didn't select a valid notes document. If you followed a link here,
                                try heading back and trying it again. If you came directly here, make sure
                                you supplied a notes ID</h3>
                            </h3>
                        </EmptyDataTemplate>

                        <ItemTemplate>
                            <header>
                                <h1><strong><%#: Item.NotesTitle %></strong></h1>
                                <h4>Asked by: <%#:Item.User %> at <%#:Item.Created %></h4>
                                <h4>Modified by: <%#:Item.UserModified %> at <%#:Item.Modified %></h4>

                            </header>
                            <p id="notescontent"><%#:Item.NotesBody %></p>

                            <br /><br />
                            <a href="EditNotes.aspx?notesID=<%#:Item.NotesID %>">
                            <asp:Button runat="server" Text="Edit this document" /></a>
                            <br /><br />
                            <a href="Module.aspx?moduleID=<%#:Item.ModuleID%>" id="parags">Go back to <%#:Item.ModuleID %></a>
                        </ItemTemplate>
                    </asp:FormView>
        </header>
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
            <asp:Button runat="server" Text="Submit answer" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancel and refresh" CausesValidation="false" OnClick="cancelButton_Click" />
        </fieldset>
    </InsertItemTemplate>
</asp:FormView>

        </LoggedInTemplate>
        <AnonymousTemplate>
            <p>Please log in to answer a question.</p>
        </AnonymousTemplate>
    </asp:LoginView>

    
</asp:Content>
