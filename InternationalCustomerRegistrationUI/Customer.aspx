<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="InternationalCustomerRegistrationUI.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/Country.css" rel="stylesheet" />
    <title></title>
</head>
<body class="body">
    <form id="form1" runat="server">
        <div>
            <center>
                <h1><i>Customer Registration</i></h1>
                <table>
                    <tr>
                        <td>Active
                           <asp:CheckBox ID="chkIsActive" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>Customer Name
                           <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                           <%-- <asp:RequiredFieldValidator ID="rfvCustomerName" runat="server" ForeColor="Red"
                                ControlToValidate="txtCustomerName" ErrorMessage="CustomerName is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCountry" Text="Country Name" runat="server"></asp:Label>
                        </td>
                        <td style="text-align: left">&nbsp;
                         <asp:DropDownList ID="ddlCountries" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged">
                         </asp:DropDownList>
                           <%-- <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ForeColor="Red"
                                ControlToValidate="ddlCountries" ErrorMessage="Country Name is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblState" runat="server" Text="State Name:" />
                        </td>
                        <td style="text-align: left">&nbsp;
                         <asp:DropDownList ID="ddlStates" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged">
                         </asp:DropDownList>
                            <%--<asp:RequiredFieldValidator ID="rfvStateName" runat="server" ForeColor="Red"
                                ControlToValidate="ddlStates" ErrorMessage="State Name is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblDistrict" runat="server" Text="District Name:" />
                        </td>
                        <td style="text-align: left">&nbsp;
                         <asp:DropDownList ID="ddlDistricts" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlDistricts_SelectedIndexChanged">
                         </asp:DropDownList>
                            <%--<asp:RequiredFieldValidator ID="rfvDistrictname" runat="server" ForeColor="Red"
                                ControlToValidate="ddlDistricts" ErrorMessage="District Name is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblCity" runat="server" Text="City Name:" />
                        </td>
                        <td style="text-align: left">&nbsp;
                         <asp:DropDownList ID="ddlCities" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged">
                         </asp:DropDownList>
                           <%-- <asp:RequiredFieldValidator ID="rfvCityName" runat="server" ForeColor="Red"
                                ControlToValidate="ddlCities" ErrorMessage="City Name is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblVillage" runat="server" Text="Village Name:" />
                        </td>
                        <td style="text-align: left">&nbsp;
                         <asp:DropDownList ID="ddlVillages" AutoPostBack="true" runat="server">
                         </asp:DropDownList>
                           <%-- <asp:RequiredFieldValidator ID="rfvVillageName" runat="server" ForeColor="Red"
                                ControlToValidate="ddlVillages" ErrorMessage="Village Name is required"></asp:RequiredFieldValidator>--%>
                        </td>
                    </tr>
                    <tr>
                        <td>Pincode 
                        </td>
                        <td>
                            <asp:TextBox ID="txtPincode" runat="server">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:FileUpload ID="fulUploadFile" runat="server" />
                            <asp:Button ID="btnUpload" runat="server" Text="Upload File" />
                            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="cssbtnSave" OnClick="btnSave_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="cssbtnClear" OnClick="btnClear_Click1" />
                        </td>
                    </tr>
                    <tr>
                        <asp:Label ID="lblDisplayStatus" runat="server" Enabled="false"></asp:Label>
                    </tr>

                </table>
            </center>
        </div>
        <div>
            <asp:GridView ID="gvCustomerDetails" runat="server" AutoGenerateColumns="false" Width="100px" Height="50px" ShowFooter="true" HeaderStyle-Height="50px" HeaderStyle-Horizentalalign="center" RowStyle-Horizenralalign="center" RowStyle-Height="60px" EmptyDataRowStyle-BackColor="#00ffff" OnRowCommand="gvCustomerDetails_RowCommand" CssClass="auto-style1">
                <AlternatingRowStyle BackColor="Yellow" ForeColor="Black" />
                <Columns>
                    <%--<asp:TemplateField HeaderText="Customer Id">
                        <ItemTemplate>
                            <%# Eval("CustomerId") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>--%>
                    <asp:TemplateField HeaderText="CustomerName">
                        <ItemTemplate>
                            <%# Eval("CustomerName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country Name">
                        <ItemTemplate>
                            <%# Eval("CountryName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="State Name">
                        <ItemTemplate>
                            <%# Eval("StateName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="District Name ">
                        <ItemTemplate>
                            <%# Eval("DistrictName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City Name ">
                        <ItemTemplate>
                            <%# Eval("CityName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Village Name">
                        <ItemTemplate>
                            <%# Eval("VillageName") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="IPAddress">
                        <ItemTemplate>
                            <%# Eval("IPAddress") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CreatedBy">
                        <ItemTemplate>
                            <%# Eval("CreatedBy") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateCreated">
                        <ItemTemplate>
                            <%# Eval("DateCreated") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="UpdatedBy">
                        <ItemTemplate>
                            <%# Eval("UpdatedBy") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateUpdated">
                        <ItemTemplate>
                            <%# Eval("DateUpdated") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IsDeleted">
                        <ItemTemplate>
                            <%# Eval("IsDeleted") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DeletedBy">
                        <ItemTemplate>
                            <%# Eval("DeletedBy") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="DateDeleted">
                        <ItemTemplate>
                            <%# Eval("DateDeleted") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Pincode">
                        <ItemTemplate>
                            <%# Eval("Pincode") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="cssbtnEdit" CommandName="cmdEdit" CommandArgument='<%# Eval("CustomerId") %>' />
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="cssbtnDelete" OnClientClick="return confirm('Are you sure you want to delete this Record?');" CommandName="cmdDelete" CommandArgument='<%# Eval("CustomerId") %>' />
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                </Columns>
                <EmptyDataRowStyle BackColor="#527452"></EmptyDataRowStyle>
                <HeaderStyle Height="50px" HorizontalAlign="Center"></HeaderStyle>
                <RowStyle HorizontalAlign="Center" Height="60px"></RowStyle>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
