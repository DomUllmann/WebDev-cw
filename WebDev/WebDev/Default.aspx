<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDev._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="wrapper style1 first">
            You are here: <a href="/Default.aspx">Home</a>
                </div>
        </div>
    </div>
    <!-- Home -->
    <section>
        <div class="wrapper style1">
          <article class="container" id="top">
            <div class="row">
              <div class="col-lg-4 image fit"><img src="/Content/images/icon.jpg" alt="Welcome!" /></div>
              <div class="col-lg-8">
                <header>
                  <h1>Welcome to <strong>U-Notes</strong>!</h1>
                </header>
                <p>With U-Notes you can easily share your knowledge about your University subjects and modules with your fellow students.</p>
                <p>You can either view and edit collaborative notes document or if you need help with something specific, just ask a question in the Q&A section and wait till someone answers! </p>
              </div>
            </div>
          </article>
        </div>
    </section>
    <section>

<!-- List of topics -->
    <asp:ListView ID="subjectList" runat="server"
        DataKeyNames="SubjectID" GroupItemCount="1"
        ItemType="WebDev.Models.Subject" SelectMethod="GetSubjects">
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
                        <a href="Subject.aspx?subjectID=<%#:Item.SubjectID%>" id="parags"><%#:Item.SubjectName %></a>
                    </td>
                        </tr>
                </ItemTemplate>
        <LayoutTemplate>
            <div class="wrapper style1" id="meh">
                <div class="contentTable">
                    
                        <div class="noteslist">
            <div class="container">
            <div class="row">
                <div class="col-lg-3"></div>
                    <div class="col-lg-6">
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
