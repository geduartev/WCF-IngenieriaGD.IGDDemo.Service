<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Ajax-enabling your WCF services</title>
    <script type="text/javascript" language="javascript">
        function LookupCourses() {
            tempuri.org.ICourseService.GetCourseList(OnLookupComplete, OnError);
        };

        function OnLookupComplete(result, state) {
            var sel = $("#Select1");
            sel.lenght = 0;
            for (i in result)
                sel.add(new Option(result[i], result[i]));
        };

        function OnError(result) {
            alert("Error: " + result.get_message());
        };
    </script>
    <style type="text/css">
        #Select1 {
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager id="ScriptManager1" runat="server">
                <services>
                    <asp:ServiceReference Path="~/courses.svc" />
                </services>
            </asp:ScriptManager>
        </div>
    </form>
    <select id ="Select1" name="D1">
    </select>
    <%--TODO: Validar por que no llama al evento OnClick para que cargue desde WS WCF la data.--%>
    <input id="Button1" type="button" value="Load Courses" onclick="return LookupCourses();" />
</body>
</html>
