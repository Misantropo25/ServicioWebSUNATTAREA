<%@ Page  Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaRUC.aspx.cs" Inherits="ClienteWebCSharp.ConsultaRUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <link href="Content/Estilos.css" rel="stylesheet" />  
    
    <div class="container">
		<div class="header" id="divHeader">
			<div class="col-md-10 col-md-offset-1">
	        	<img src="/App_Themes/Tema1/logo_2015.png" class="imgLogo">
			</div>
			</div>
	    </div>

    <div class="panel panel-primary">
	        		<div class="panel-heading">Criterios de la búsqueda</div>
	        		<div class="panel-body">
	        			<div class="text-center divBotonesFiltro text-nowrap">
						  	<div role="group" class="btn-group">
						                              <p>
                            <asp:Label ID="lbl1" Cssclass="Label1" runat="server" Text="Ingrese el RUC:"></asp:Label>
                        </p>
                        <p>
                            <asp:TextBox ID="tbRUC" Cssclass="TextoB" runat="server"></asp:TextBox>
                        </p>
                        <p>
                            <asp:Button ID="btnBuscar"  Cssclass="Buttonbusca" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        </p>
						    </div>
					    </div>                       
	                            </div>          
	        		</div>
<div class="container">
     <div class="panel panel-primary">
	        		<div class="panel-heading">Resultado de la Búsqueda</div>
	        		<div class="panel-body">
	        			<div class="text-center divBotonesFiltro text-nowrap">
						  	<div role="group" class="btn-group">


	    <p>
        <asp:Table ID="tableResultados" Cssclass="TablaInfo" runat="server" Width="500px"></asp:Table>
    </p>
    <p>
        <asp:Button ID="btnVolver" Cssclass="Buttonvolver" runat="server" Text="Volver" />
    </p>
	</div>
	</div>                       
	</div>          
	</div>
	</div>
</asp:Content>
