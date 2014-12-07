<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDev._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Home -->
<div class="wrapper style1 first">
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

<!-- List of topics -->
<div class="wrapper style1" id = "meh">
  <div class="contentTable">
    <ul class = "noteslist">
      <h1 id="title">Subject Areas</h1>
      <li id="parags"><a href="modulepage.html"id="parags">Computer Science</a></li>
      <li id="parags"><a href="/notes"id="parags">Topic 2 </a></li>
      <li id="parags"><a href="/notes"id="parags">Topic 3 </a></li>
    </ul>
  </div>
</div>

</asp:Content>
