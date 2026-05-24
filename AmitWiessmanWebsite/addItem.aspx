<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addItem.aspx.cs" Inherits="addItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form name="formPage"
     method="post"
     runat="server"
   >

    שם השיר:
     <input type="text"
         name="songName"
         id="songName"
         placeholder="example"
         required />

     <span class="error" id="nameError"></span>

     <br /><br />

     סוג השיר:
     <input type="text"
         name="songType"
         id="songType"
         placeholder="example"
         required />

     <span class="error" id="emailError"></span>

     <br /><br />

    אורך השיר בשניות
        :
     <input type="text"
         name="songLength"
         id="songLength"
         placeholder="example"
         required />

     <span class="error" id="passError"></span>

     <br /><br />


     <input id="Submit1"
         type="submit"
         value="שלח" />

 </form>
        <%=st %>

 <br />

</asp:Content>

