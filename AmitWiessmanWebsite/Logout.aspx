<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Logout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    // מוחק ומאפס את כל משתני ה-Session (שם המשתמש, סטטוס מנהל וכו') כדי לנתק אותו מהמערכת
    <%Session.Abandon();
        Response.Redirect("sign in.aspx");
            %>
    
</asp:Content>

