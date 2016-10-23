<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xpath-default-namspase="http://tempuri.org/TestSchema.xsd"
>
  <xsl:template match="/">

    <html>
      <body>
        <div>
        <h1>Library</h1>
</div>
        <table>
          <xsl:for-each select="library/book">
            <xsl:call-template name="row">
<xsl:with-param name="index" select="position()"></xsl:with-param>
          </xsl:call-template>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
  <xsl:template name="row">
    <xsl:param name="index"></xsl:param>
    <xsl:variable name="color">
      <xsl:choose>
<xsl:when test="$index mod 2 = 0">
  <xsl:value-of select="'red'"/>
      </xsl:when>
      <xsl:otherwise>
  <xsl:value-of select="'blue'"/>
        
      
      </xsl:otherwise>
      </xsl:choose>
    
    </xsl:variable>
    <tr bgcolor="{$color}">
      <td>
        <xsl:value-of select="title"/>
      </td>
          <td>
        <xsl:value-of select="$index"/>
      </td>
    </tr>
  </xsl:template>
</xsl:stylesheet>
