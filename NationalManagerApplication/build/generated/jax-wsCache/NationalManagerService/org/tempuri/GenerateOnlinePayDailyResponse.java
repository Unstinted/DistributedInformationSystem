
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
 *         &lt;element name="GenerateOnlinePayDailyResult" type="{http://tempuri.org/}ArrayOfOnlinePayment" minOccurs="0"/>
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
    "generateOnlinePayDailyResult"
})
@XmlRootElement(name = "GenerateOnlinePayDailyResponse")
public class GenerateOnlinePayDailyResponse {

    @XmlElement(name = "GenerateOnlinePayDailyResult")
    protected ArrayOfOnlinePayment generateOnlinePayDailyResult;

    /**
     * Gets the value of the generateOnlinePayDailyResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfOnlinePayment }
     *     
     */
    public ArrayOfOnlinePayment getGenerateOnlinePayDailyResult() {
        return generateOnlinePayDailyResult;
    }

    /**
     * Sets the value of the generateOnlinePayDailyResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfOnlinePayment }
     *     
     */
    public void setGenerateOnlinePayDailyResult(ArrayOfOnlinePayment value) {
        this.generateOnlinePayDailyResult = value;
    }

}
