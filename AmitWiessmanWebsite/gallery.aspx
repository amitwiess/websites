<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<style>
    .gallery {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 12px;
        padding: 20px;
    }

    .gallery img {
        width: 50;
        height: 180px;
        object-fit: cover;
        border-radius: 10px;
        transition: transform 0.2s ease, box-shadow 0.2s ease;
        cursor: pointer;
    }

    .gallery img:hover {
        transform: scale(1.04);
        box-shadow: 0 4px 12px rgba(0,0,0,0.2);
    }

    h1 {
        text-align: center;
        margin-top: 20px;
    }
</style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>גלריית תמונות</h1>

<div class="gallery">
    <img src="תמונות/טונה1.jpeg" />
    <img src="תמונות/טונה22222.jpeg" />
    <img src="תמונות/אילללל.jpeg" />
    <img src="תמונות/עומרררררר.jpeg" />
    <img src="תמונות/shae111111.jpeg" />
    <img src="תמונות/shae123123.jpeg" />
</div>

</asp:Content>