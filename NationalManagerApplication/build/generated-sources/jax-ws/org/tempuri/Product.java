
package org.tempuri;

import java.math.BigDecimal;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for Product complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType name="Product">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="Productcode" type="{http://microsoft.com/wsdl/types/}guid"/>
 *         &lt;element name="Productname" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="UnitSalesPrice" type="{http://www.w3.org/2001/XMLSchema}decimal"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Product", propOrder = {
    "productcode",
    "productname",
    "unitSalesPrice"
})
public class Product {

    @XmlElement(name = "Productcode", required = true)
    protected String productcode;
    @XmlElement(name = "Productname")
    protected String productname;
    @XmlElement(name = "UnitSalesPrice", required = true)
    protected BigDecimal unitSalesPrice;

    /**
     * Gets the value of the productcode property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProductcode() {
        return productcode;
    }

    /**
     * Sets the value of the productcode property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProductcode(String value) {
        this.productcode = value;
    }

    /**
     * Gets the value of the productname property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getProductname() {
        return productname;
    }

    /**
     * Sets the value of the productname property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setProductname(String value) {
        this.productname = value;
    }

    /**
     * Gets the value of the unitSalesPrice property.
     * 
     * @return
     *     possible object is
     *     {@link BigDecimal }
     *     
     */
    public BigDecimal getUnitSalesPrice() {
        return unitSalesPrice;
    }

    /**
     * Sets the value of the unitSalesPrice property.
     * 
     * @param value
     *     allowed object is
     *     {@link BigDecimal }
     *     
     */
    public void setUnitSalesPrice(BigDecimal value) {
        this.unitSalesPrice = value;
    }

}
