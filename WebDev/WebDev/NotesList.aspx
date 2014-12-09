<%@ Page Title="List of Notes Documents" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NotesList.aspx.cs" Inherits="WebDev.NotesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <section>
        <div class="wrapper style1 first">
          <article class="container" id="top">
            <div class="row">
              <div class="col-lg-4 image fit"><img src="/Content/images/notes.png" alt="Here's the best place learn something new!" /></div>
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
                            <p>Here's a list of all the notes documents for <b><%#: Item.ModuleTitle %></b>!</p>
                  <p>Here you'll find all of the documents that have been written for this module. You can view the documents, modify them and create your own documents as well.<br />
                      Feel free to contribute with your knowledge to our community!</p>
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
                <h1 id="title">Notes</h1>
            <table class="table">
                        <tbody>
        <asp:ListView ID="notesList" runat="server"
        DataKeyNames="NotesID" GroupItemCount="1"
        ItemType="WebDev.Models.Notes" SelectMethod="GetNotes">
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
                        <a href="ViewNotes.aspx?notesID=<%#:Item.NotesID%>" id="parags"><%#:Item.NotesTitle %></a>
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

