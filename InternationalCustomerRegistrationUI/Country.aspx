<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="InternationalCustomerRegistrationUI.Country" %>

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
                <asp:Panel ID="panel1" runat="server">
                    <table>
                        <th>
                            <h2>Enter Country Name</h2>
                        </th>
                        <tr>
                            <td>Active
                           <asp:CheckBox ID="chkIsActive" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>CountryName
                           <asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ForeColor="Red" ControlToValidate="txtCountryName" Text="CountryName is required"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="cssbtnSave" OnClick="btnSave_Click1" />
                            </td>
                            <td>
                                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="cssbtnClear" />
                            </td>
                        </tr>
                        <tr>
                            <asp:Label ID="lblDisplayStatus" runat="server" Enabled="false"></asp:Label>
                        </tr>
                    </table>
                </asp:Panel>
            </center>
        </div>
        <div>
            <h3>View Countries</h3>

        </div>
        <div>
            <asp:GridView ID="gvCountryDetails" runat="server" AutoGenerateColumns="false" Width="100px" Height="50px" ShowFooter="true" HeaderStyle-Height="50px" HeaderStyle-Horizentalalign="center" RowStyle-Horizenralalign="center" RowStyle-Height="60px" EmptyDataRowStyle-BackColor="#00ffff" OnRowCommand="gvCountryDetails_RowCommand">
                <AlternatingRowStyle BackColor="Yellow" ForeColor="Black" />
                <Columns>
                    <asp:TemplateField HeaderText="CountryId" Visible="false">
                        <ItemTemplate>
                            <%#Eval("CountryId") %>
                        </ItemTemplate>
                        <FooterStyle BackColor="#66ff33" ForeColor="White" />
                        <HeaderStyle BackColor="#66ff33" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CountryName">
                        <ItemTemplate>
                            <%# Eval("CountryName") %>
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
                    <asp:TemplateField HeaderText="Edit">
                        <HeaderStyle BackColor="#527452" ForeColor="White" />
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="cssbtnEdit" CommandName="cmdEdit" CommandArgument='<%# Eval("CountryId") %>' />
                        </ItemTemplate>
                        <FooterStyle BackColor="#527452" ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <HeaderStyle BackColor="#527452" ForeColor="White" />
                        <FooterStyle BackColor="#527452" ForeColor="White" />
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="cssbtnDelete" OnClientClick="return confirm('Are you sure you want to delete this Record?');" CommandName="cmdDelete" CommandArgument='<%# Eval("CountryId") %>' />
                        </ItemTemplate>
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
