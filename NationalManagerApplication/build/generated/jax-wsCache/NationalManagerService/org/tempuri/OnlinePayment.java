
package org.tempuri;

import java.math.BigDecimal;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlSchemaType;
import javax.xml.bind.annotation.XmlType;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 * <p>Java class for OnlinePayment complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="OnlinePayment">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="product" type="{http://microsoft.com/wsdl/types/}guid"/>
 *         &lt;element name="OrderDetails" type="{http://microsoft.com/wsdl/types/}guid"/>
 *         &lt;element name="OrderPayment" type="{http://www.w3.org/2001/XMLSchema}dateTime"/>
 *         &lt;element name="payment" type="{http://www.w3.org/2001/XMLSchema}decimal"/>
 *         &lt;element name="CheckNo" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="Bankname" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="UPrice" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="USold" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="TPP" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "OnlinePayment", propOrder = {
    "product",
    "orderDetails",
    "orderPayment",
    "payment",
    "checkNo",
    "bankname",
    "uPrice",
    "uSold",
    "tpp"
})
public class OnlinePayment {

    @XmlElement(required = true)
    protected String product;
    @XmlElement(name = "OrderDetails", required = true)
    protected String orderDetails;
    @XmlElement(name = "OrderPayment", required = true)
    @XmlSchemaType(name = "dateTime")
    protected XMLGregorianCalendar orderPayment;
    @XmlElement(required = true)
    protected BigDecimal payment;
    @XmlElement(name = "CheckNo")
    protected int checkNo;
    @XmlElement(name = "Bankname")
    protected String bankname;
    @XmlElement(name = "UPrice")
    protected int uPrice;
    @XmlElement(name = "USold")
    protected int uSold;
    @XmlElement(name = "TPP")
    protected int tpp;

    /**
     * Gets the value of the product property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProduct() {
        return product;
    }

    /**
     * Sets the value of the product property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProduct(String value) {
        this.product = value;
    }

    /**
     * Gets the value of the orderDetails property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOrderDetails() {
        return orderDetails;
    }

    /**
     * Sets the value of the orderDetails property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOrderDetails(String value) {
        this.orderDetails = value;
    }

    /**
     * Gets the value of the orderPayment property.
     * 
     * @return
     *     possible object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public XMLGregorianCalendar getOrderPayment() {
        return orderPayment;
    }

    /**
     * Sets the value of the orderPayment property.
     * 
     * @param value
     *     allowed object is
     *     {@link XMLGregorianCalendar }
     *     
     */
    public void setOrderPayment(XMLGregorianCalendar value) {
        this.orderPayment = value;
    }

    /**
     * Gets the value of the payment property.
     * 
     * @return
     *     possible object is
     *     {@link BigDecimal }
     *     
     */
    public BigDecimal getPayment() {
        return payment;
    }

    /**
     * Sets the value of the payment property.
     * 
     * @param value
     *     allowed object is
     *     {@link BigDecimal }
     *     
     */
    public void setPayment(BigDecimal value) {
        this.payment = value;
    }

    /**
     * Gets the value of the checkNo property.
     * 
     */
    public int getCheckNo() {
        return checkNo;
    }

    /**
     * Sets the value of the checkNo property.
     * 
     */
    public void setCheckNo(int value) {
        this.checkNo = value;
    }

    /**
     * Gets the value of the bankname property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getBankname() {
        return bankname;
    }

    /**
     * Sets the value of the bankname property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setBankname(String value) {
        this.bankname = value;
    }

    /**
     * Gets the value of the uPrice property.
     * 
     */
    public int getUPrice() {
        return uPrice;
    }

    /**
     * Sets the value of the uPrice property.
     * 
     */
    public void setUPrice(int value) {
        this.uPrice = value;
    }

    /**
     * Gets the value of the uSold property.
     * 
     */
    public int getUSold() {
        return uSold;
    }

    /**
     * Sets the value of the uSold property.
     * 
     */
    public void setUSold(int value) {
        this.uSold = value;
    }

    /**
     * Gets the value of the tpp property.
     * 
     */
    public int getTPP() {
        return tpp;
    }

    /**
     * Sets the value of the tpp property.
     * 
     */
    public void setTPP(int value) {
        this.tpp = value;
    }

}
