<%@ Page Language="C#" %>
<%@ Assembly Name="Castle.MonoRail.Framework" %>
<%@ Assembly Name="Castle.MonoRail.Views.AspView" %>
<aspView:properties>
<%
%>
</aspView:properties>
a. Some text, located before the capturedContent component
<component:CaptureFor id="capturedContent">
This content should be rendered in the captured-for place holder
</component:CaptureFor>
b. Some text, located after the capturedContent component
This text should be rendered right after text a.
