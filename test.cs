<configuration>
<system.webServer>
<rewrite>
<rules>
<rule name="MainRedirectRule" stopProcessing="true">
<match url="(.*)" />
<conditions>
<add input="{HTTP_POST}" pattern="(.*)" />
</conditions>
<action type="Redirect" url="https://softflowcloud.sharepoint.com/" />
</rule>
</rules>
</rewrite>
</system.webServer>
</configuration>