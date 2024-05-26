<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard_Web.aspx.cs" Inherits="Dashboard_Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard</title>
    <link rel="stylesheet" href="Dashoard_Web.css"/>
</head>
<body>
           <!--******************Form*******************-->
    <form id="form1" runat="server">

    <div>
       <div style="height: 509px; margin-bottom: 59px">
            <div style="font-size:x-large; text-align:center;" id="title">
                <br />
                <br />
            <div>Student Ragistration Form</div><br /> </div>

           <!--******************table*******************-->

    <table style="width: 100%">
         <tr>
            <td class="modal-sm" style="width: 249px; "></td>
            <td style="width: 232px">Student ID</td>
            <td style="font-size: medium;" id="TextBox1">  <!--surf id chalti hai-->
             <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
         </tr>

         <tr>
            <td class="modal-sm" style="width: 249px; height: 34px;"></td>
            <td style="width: 232px; height: 34px;">Student Name</td>
            <td style="font-size: medium; height: 34px;" id="TextBox2">
             <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
         </tr>

         <tr>
            <td class="modal-sm" style="width: 249px; height: 18px"></td>
            <td style="height: 18px; width: 232px">Address</td>
            <td style="height: 18px">
             <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Medium" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="167px">
                    <asp:ListItem>Select Country </asp:ListItem>
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>Japan</asp:ListItem>
                    <asp:ListItem>Chaina</asp:ListItem>
                    <asp:ListItem>Amarica</asp:ListItem>
             </asp:DropDownList>
             </td>
          </tr>

          <tr>
            <td class="modal-sm" style="width: 249px">&nbsp;</td>
            <td style="width: 232px">Age</td>
            <td style="font-size: medium" id="TextBox3">
             <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
           </tr>

          <tr>
            <td class="modal-sm" style="width: 249px; height: 34px;">
                <br /></td>
            <td style="width: 232px; height: 34px;">Contact</td>
            <td style="font-size: medium; height: 34px;" id="TextBox4">
                <asp:TextBox ID="TextBox9" runat="server" MaxLength="11"></asp:TextBox></td>
           </tr>

        <!--******************OnClick_Function*******************-->

           <tr>
            <td class="modal-sm" style="width: 249px">&nbsp;</td>
            <td style="width: 232px">&nbsp;</td>
            <td style="font-size: x-large;">
           <br />
                <asp:Button ID="Button1" runat="server" BackColor="#66CCFF" BorderColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="Button1_Click" Text="Insert" Width="97px" />
                <asp:Button ID="Button2" runat="server" BackColor="#66CCFF" BorderColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="Button2_Click" Text="Update" Width="97px" style="margin-left: 13px" />
                <asp:Button ID="Button3" runat="server" BackColor="#66CCFF" BorderColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="Button3_Click" Text="Delete" Width="97px" style="margin-left: 13px" />
                <asp:Button ID="Button4" runat="server" BackColor="#66CCFF" BorderColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="Button4_Click" Text="Search" Width="97px" style="margin-left: 13px" />
                <br />
                <br />
                <br />
                Student Records<br />
            </td>
          </tr>

           <tr>
              <td class="modal-sm" style="width: 249px; height: 20px;"></td>
              <td style="width: 232px; height: 20px;"></td>
              <td style="font-size: x-large; text-align: center;">&nbsp;</td>
           </tr>

           <tr>
              <td class="modal-sm" style="width: 249px">&nbsp;</td>
              <td style="width: 232px">&nbsp;</td>
              <td>
              <asp:GridView ID="GridView1" runat="server" Width="770px"></asp:GridView><!--Data show krne k liya-->
              </td>
          </tr>

     </table>
    </div>
   </div>
 </form>
</body>
</html>
