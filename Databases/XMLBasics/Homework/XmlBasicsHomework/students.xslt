<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
                xmlns:students="urn:students"
>
  <xsl:output method="html"/>

  <xsl:template match="/">
    <h3>Students</h3>
    <table border="1">
      <thead>
        <tr>
          <th>Name</th>
          <th>birthDate</th>
          <th>phone</th>
          <th>email</th>
          <th>course</th>
          <th>specialty</th>
          <th>facultyNumber</th>
          <th>Exams</th>

        </tr>
      </thead>
      <tbody>

        <xsl:for-each select="/students:students/students:student">
          <xsl:variable name="color">
            <xsl:choose>
              <xsl:when test="position() mod 2 = 0">
                <xsl:value-of select="'grey'"/>
              </xsl:when>
              <xsl:otherwise>
                <xsl:value-of select="'lightGrey'"/>
              </xsl:otherwise>
            </xsl:choose>
          </xsl:variable>
          <tr bgcolor="{$color}">
            <td >
              <xsl:value-of select="students:name"/>
            </td>
            <td>
              <xsl:value-of select="students:birthDate"/>
            </td>
            <td>
              <xsl:value-of select="students:phone"/>
            </td>
            <td>
              <xsl:value-of select="students:email"/>
            </td>
            <td>
              <xsl:value-of select="students:course"/>
            </td>
            <td>
              <xsl:value-of select="students:specialty"/>
            </td>
            <td>
              <xsl:value-of select="students:facultyNumber"/>
            </td>
            <td>
              <table border="1">
                <xsl:for-each select="students:exams/students:exam">
                  <xsl:variable name="examColor">
                    <xsl:choose>
                      <xsl:when test="count(students:enrollments/students:enrollment[students:endorsement = 'true']) &gt; 0">
                        <xsl:value-of select="'green'"/>
                      </xsl:when>
                      <xsl:otherwise>
                        <xsl:value-of select="'red'"/>
                      </xsl:otherwise>
                    </xsl:choose>
                  </xsl:variable>
                  <tr>
                    
                    <td bgcolor="{$examColor}">
                      <p>
                        Name: 
                        <xsl:value-of select="students:name"/>
                      </p>
                      <p>
                        Tutor: 
                        <xsl:value-of select="students:tutor"/>
                      </p>
                      <p>
                        Score: 
                        <xsl:value-of select="students:score"/>
                      </p>
                    </td>
                    <td>
                      <table>
                        <tr>
                          <xsl:for-each select="students:enrollments/students:enrollment">
                            <xsl:variable name="enColor">
                              <xsl:choose>
                                <xsl:when test="students:endorsement = 'true'">
                                  <xsl:value-of select="'green'"/>
                                </xsl:when>
                                <xsl:otherwise>
                                  <xsl:value-of select="'red'"/>
                                </xsl:otherwise>
                              </xsl:choose>
                            </xsl:variable>
                            <td bgcolor="{$enColor}">
                              <p>
                                Date: 
                                <xsl:value-of select="students:date"/>
                              </p>
                              <p>
                                Score: 
                                <xsl:value-of select="students:score"/>
                              </p>
                            </td>
                          </xsl:for-each>
                        </tr>
                      </table>
                    </td>
                  </tr>
                </xsl:for-each>
              </table>
            </td>
          </tr>
        </xsl:for-each>
      </tbody>
    </table>
  </xsl:template>
</xsl:stylesheet>
