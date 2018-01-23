<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kataAsp2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>El equilibrio de NASH</h1>
        <p class="lead">
            Considerando dos compañ ía s, compañ ía 1 y compañ ía, Sus estrategias son hacer o no
            publicidad en TV.
            i la empresa 1 y 2 deciden no hacer publicidad sus ganancias son 5 0 millones cada
            una
            si una empresa decide hacer publicidad pero la otra no, las ganancias extras son 4 0
            millones y la otra 2 0 millones.
            si la empresa 1 y 2 deciden hacer publicidad sus ganancias son 27 millones cada una.
        </p>

        <table class="table">
            <tr>
                <td>
                    <b>Compañía A / Compañía B</b>
                </td>
                <td>
                    Hace Publicidad
                </td>
                <td>
                    No Hace Publicidad
                </td>
            </tr>
            <tr>
                <td>
                    Hace Publicidad
                </td>
                <td>
                    <%= Matrix()[0] %> 
                </td>
                <td>
                    <%= Matrix()[1] %> 
                </td>
            </tr>
            <tr>
                <td>
                    No Hace Publicidad
                </td>
                <td>
                    <%= Matrix()[2] %> 
                </td>
                <td>
                    <%= Matrix()[3] %> 
                </td>
            </tr>
        </table>

        <p>
            el valor de equilibrio de Nash es: <b> <%= NashValueString() %> </b>
        </p>
    </div>

</asp:Content>
