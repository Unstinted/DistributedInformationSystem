
package org.tempuri;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="GenerateProductReportWeeklyResult" type="{http://tempuri.org/}ArrayOfOnlineOrderDetails" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "generateProductReportWeeklyResult"
})
@XmlRootElement(name = "GenerateProductReportWeeklyResponse")
public class GenerateProductReportWeeklyResponse {

    @XmlElement(name = "GenerateProductReportWeeklyResult")
    protected ArrayOfOnlineOrderDetails generateProductReportWeeklyResult;

    /**
     * Gets the value of the generateProductReportWeeklyResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfOnlineOrderDetails }
     *     
     */
    public ArrayOfOnlineOrderDetails getGenerateProductReportWeeklyResult() {
        return generateProductReportWeeklyResult;
    }

    /**
     * Sets the value of the generateProductReportWeeklyResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfOnlineOrderDetails }
     *     
     */
    public void setGenerateProductReportWeeklyResult(ArrayOfOnlineOrderDetails value) {
        this.generateProductReportWeeklyResult = value;
    }

}
