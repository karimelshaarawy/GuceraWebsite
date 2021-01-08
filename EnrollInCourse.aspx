<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnrollInCourse.aspx.cs" Inherits="Gucera.EnrollInCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enrolment</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 187px;
            left: 113px;
            z-index: 1;
            width: 78px;
        }
        .auto-style2 {
            position: absolute;
            top: 160px;
            left: 64px;
            z-index: 1;
            width: 372px;
            color:red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div> 
                <h1> Enroll in Course</h1>
            </div>
            <div>
                Course ID   <asp:TextBox runat="server" ID="cid"   />
            </div>
            <br />
            <div>
                Instructor ID <asp:TextBox runat="server" id="instid" />
            </div>
            <br />
            <div>

                <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text=""   ></asp:Label>

            </div>
        </div>
        <p>

                <asp:Button ID="enroll" runat="server" CssClass="auto-style1" Text="Enroll" OnClick="enroll_Click" />

            </p>
    </form>
</body>
</html>
