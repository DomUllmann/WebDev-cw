<%@ Page Title="Subject" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subject.aspx.cs" Inherits="WebDev.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div class="wrapper style1 first">
          <article class="container" id="top">
            <div class="row">
              <div class="col-lg-4 image fit"><img src="/Content/images/study.jpg" alt="Let's study!" /></div>
              <div class="col-lg-8">
                    <asp:FormView ID="subject" runat="server" DataKeyNames="SubjectID"
                        ItemType ="WebDev.Models.Subject" SelectMethod ="GetSubjects">

                        <ItemTemplate>
                            <header>
                                <h1><strong><%#: Item.SubjectName %></strong>!</h1>
                            </header>
                            <p>Welcome to the subject page for <b><%#: Item.SubjectName %></b>!</p>
                        </ItemTemplate>
                    </asp:FormView>
                  <p>Here you'll find a list of all of the modules that currently have Notes or Questions here on U-Note.<br />
                You can either view and edit collaborative notes document or if you need help with something specific, just ask a question in the Q&A section and wait till someone answers! </p>
              </div>
            </div>
          </article>
        </div>
    </section>
    <section>
        <asp:ListView ID="moduleList" runat="server"
        DataKeyNames="ModuleID" GroupItemCount="1"
        ItemType="WebDev.Models.Module" SelectMethod="GetModules">
        <EmptyDataTemplate>
            <table>
                <tr>
                    <td>No data was returned.</td>
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
                        <a href="Module.aspx?moduleID=<%#:Item.ModuleID%>" id="parags"><%#:Item.ModuleID %> - <%#: Item.ModuleTitle %></a>
                    </td>
                        </tr>
                </ItemTemplate>
        <LayoutTemplate>
            <div class="wrapper style1" id="meh">
                <div class="contentTable">
                    
                        <div class="noteslist">
            <div class="container">
            <div class="row">
            <table class="table">
                        <tbody>
                            <tr id="groupPlaceholder" runat="server"></tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                </div>
            </div>
                        </div>
                    </div>
                </div>
        </LayoutTemplate>
    </asp:ListView>
    </section>
</asp:Content>
