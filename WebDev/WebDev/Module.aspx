﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Module.aspx.cs" Inherits="WebDev.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
	   <div class="container">
        <div class="row">
            <div class="wrapper style1 first">
                <asp:FormView ID="crumb" runat="server" DataKeyNames="ID" 
                    ItemType="WebDev.Models.Breadcrumb" SelectMethod="GetBreadcrumbs">
                    <EmptyDataTemplate></EmptyDataTemplate>
                    <ItemTemplate>
                        You are here: <a href="Default.aspx">Home</a> -> <a href="Subject.aspx?subjectID=<%#:Item.SubjectID %>"><%#:Item.SubjectName %></a>
                        -> <a href="Module.aspx?moduleID=<%#:Item.ModuleID %>"><%#:Item.ModuleID %></a>
                    </ItemTemplate>
                </asp:FormView>
                </div>
        </div>
    </div>
	
	<section>
        <div class="wrapper style1 first">
            <article class="container" id="top">
                <div class="row">
                    <div class="col-lg-4 image fit">
                        <img src="/Content/images/study.jpg" alt="Let's study!" /></div>
                    <div class="col-lg-8">
                        <asp:FormView ID="module" runat="server" DataKeyNames="ModuleID"
                            ItemType="WebDev.Models.Module" SelectMethod="GetModules">
                            <EmptyDataTemplate>
                                <h1><strong>Ooops! Something has gone wrong!</strong></h1>
                                <h3>It looks like you didn't select a proper module. If you followed a link here,
                                try heading back and trying it again. If you came directly here, make sure
                                you supplied a module ID</h3>
                                </h3>
                            </EmptyDataTemplate>

                            <ItemTemplate>
                                <header>
                                    <h1><strong><%#: Item.ModuleID %>: <%#: Item.ModuleTitle %></strong>!</h1>
                                </header>
                                <p>Welcome to the module page for <b><%#: Item.ModuleTitle %></b>!</p>
                                <p>
                                    Here you'll find a list of all of the notes that have been created for the lectures covered so far in <%#:Item.ModuleTitle %>!<br />
                                    You'll also find a collection of questions asked by fellow students about topics relating to this module. Hopefully they've got some
                      great answers too!
                                </p>

                                <p><%#:Item.Description %></p>
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
                        <div class="row2">
                            <h1 id="title">Questions</h1>
                            <table class="table">
                                <tbody>
                                    <asp:ListView ID="questionList" runat="server"
                                        DataKeyNames="QuestionID" GroupItemCount="3"
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
                                                <td >
                                                    <a href="ViewQuestion.aspx?questionID=<%#:Item.QuestionID%>" id="parags"><%#:Item.QuestionTitle %></a>
                                                </td>
                                            </tr>
                                        </ItemTemplate>

                                        <LayoutTemplate>
                                            <tr id="groupPlaceholder" runat="server"></tr>

                                        </LayoutTemplate>
                                    </asp:ListView>

                                    <asp:FormView ID="mod" runat="server" DataKeyNames="ModuleID"
                                        ItemType="WebDev.Models.Module" SelectMethod="GetModules">
                                        <EmptyDataTemplate>
                                        </EmptyDataTemplate>

                                        <ItemTemplate>

                                            <h4><a href="QuestionList.aspx?moduleID=<%#: Item.ModuleID %>" id="parags">See all questions</a></h4>

                                        </ItemTemplate>
                                    </asp:FormView>


                                </tbody>
                            </table>
                        </div>

                        <div class="row2">
                            <h1 id="title">Notes</h1>
                            <table class="table">
                                <tbody>
                                    <asp:ListView ID="ListView2" runat="server"
                                        DataKeyNames="NotesID" GroupItemCount="3"
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

                                    <asp:FormView ID="mod2" runat="server" DataKeyNames="ModuleID"
                                        ItemType="WebDev.Models.Module" SelectMethod="GetModules">
                                        <EmptyDataTemplate>
                                        </EmptyDataTemplate>

                                        <ItemTemplate>

                                            <h4><a href="NotesList.aspx?moduleID=<%#: Item.ModuleID %>" id="parags">See all notes</a></h4>

                                        </ItemTemplate>
                                    </asp:FormView>



                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
