
package org.tempuri;

import java.math.BigDecimal;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for OnlineOrderDetails complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="OnlineOrderDetails">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="OrderIdentity" type="{http://microsoft.com/wsdl/types/}guid"/>
 *         &lt;element name="ProductDetail" type="{http://microsoft.com/wsdl/types/}guid"/>
 *         &lt;element name="OrderQuantity" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="Price" type="{http://www.w3.org/2001/XMLSchema}decimal"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "OnlineOrderDetails", propOrder = {
    "orderIdentity",
    "productDetail",
    "orderQuantity",
    "price"
})
public class OnlineOrderDetails {

    @XmlElement(name = "OrderIdentity", required = true)
    protected String orderIdentity;
    @XmlElement(name = "ProductDetail", required = true)
    protected String productDetail;
    @XmlElement(name = "OrderQuantity")
    protected int orderQuantity;
    @XmlElement(name = "Price", required = true)
    protected BigDecimal price;

    /**
     * Gets the value of the orderIdentity property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getOrderIdentity() {
        return orderIdentity;
    }

    /**
     * Sets the value of the orderIdentity property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setOrderIdentity(String value) {
        this.orderIdentity = value;
    }

    /**
     * Gets the value of the productDetail property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProductDetail() {
        return productDetail;
    }

    /**
     * Sets the value of the productDetail property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProductDetail(String value) {
        this.productDetail = value;
    }

    /**
     * Gets the value of the orderQuantity property.
     * 
     */
    public int getOrderQuantity() {
        return orderQuantity;
    }

    /**
     * Sets the value of the orderQuantity property.
     * 
     */
    public void setOrderQuantity(int value) {
        this.orderQuantity = value;
    }

    /**
     * Gets the value of the price property.
     * 
     * @return
     *     possible object is
     *     {@link BigDecimal }
     *     
     */
    public BigDecimal getPrice() {
        return price;
    }

    /**
     * Sets the value of the price property.
     * 
     * @param value
     *     allowed object is
     *     {@link BigDecimal }
     *     
     */
    public void setPrice(BigDecimal value) {
        this.price = value;
    }

}
