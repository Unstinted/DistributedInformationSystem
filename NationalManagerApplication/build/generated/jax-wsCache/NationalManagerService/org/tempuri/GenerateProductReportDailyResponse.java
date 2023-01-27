
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
 *         &lt;element name="GenerateProductReportDailyResult" type="{http://tempuri.org/}ArrayOfOnlineOrderDetails" minOccurs="0"/>
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
    "generateProductReportDailyResult"
})
@XmlRootElement(name = "GenerateProductReportDailyResponse")
public class GenerateProductReportDailyResponse {

    @XmlElement(name = "GenerateProductReportDailyResult")
    protected ArrayOfOnlineOrderDetails generateProductReportDailyResult;

    /**
     * Gets the value of the generateProductReportDailyResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfOnlineOrderDetails }
     *     
     */
    public ArrayOfOnlineOrderDetails getGenerateProductReportDailyResult() {
        return generateProductReportDailyResult;
    }

    /**
     * Sets the value of the generateProductReportDailyResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfOnlineOrderDetails }
     *     
     */
    public void setGenerateProductReportDailyResult(ArrayOfOnlineOrderDetails value) {
        this.generateProductReportDailyResult = value;
    }

}
