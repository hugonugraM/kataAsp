<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kataAsp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>El equilibrio de NASH</h1>
        <p class="lead">
            si confiesas pero tu compañero no, te dejaremos en libertad mientras que a tu
            compañero le daremos 1 0 año s de cárcel.
            el equilibrio de nash es una situacion en donde los individuos o jugadores no tienen
            ningun incentivo a cambiar su estrategia tomando en cuenta la estrategia de sus
            oponentes.
            si vemos que ambos confiesan , les daremos 5 año s a cada uno.
            si ninguno de los dos confiesa, les daremos 1 año de cárcel a cada uno 
        </p>

        <table class="table">
            <tr>
                <td>
                    <b>prisionero Al / prisionero Bill</b>
                </td>
                <td>
                    No Confiesa
                </td>
                <td>
                    Confiesa
                </td>
            </tr>
            <tr>
                <td>
                    No Confiesa
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
                    Confiesa
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
