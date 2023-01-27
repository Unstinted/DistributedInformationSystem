
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
 *         &lt;element name="GenerateOnlinePayWeeklyResult" type="{http://tempuri.org/}ArrayOfOnlinePayment" minOccurs="0"/>
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
    "generateOnlinePayWeeklyResult"
})
@XmlRootElement(name = "GenerateOnlinePayWeeklyResponse")
public class GenerateOnlinePayWeeklyResponse {

    @XmlElement(name = "GenerateOnlinePayWeeklyResult")
    protected ArrayOfOnlinePayment generateOnlinePayWeeklyResult;

    /**
     * Gets the value of the generateOnlinePayWeeklyResult property.
     * 
     * @return
     *     possible object is
     *     {@link ArrayOfOnlinePayment }
     *     
     */
    public ArrayOfOnlinePayment getGenerateOnlinePayWeeklyResult() {
        return generateOnlinePayWeeklyResult;
    }

    /**
     * Sets the value of the generateOnlinePayWeeklyResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link ArrayOfOnlinePayment }
     *     
     */
    public void setGenerateOnlinePayWeeklyResult(ArrayOfOnlinePayment value) {
        this.generateOnlinePayWeeklyResult = value;
    }

}
