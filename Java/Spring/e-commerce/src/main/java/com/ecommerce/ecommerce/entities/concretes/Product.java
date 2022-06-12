package com.ecommerce.ecommerce.entities.concretes;
import com.ecommerce.ecommerce.core.entities.IEntity;
import lombok.Data;
import javax.persistence.*;

@Table(name="products")
@Entity
@Data
public class Product implements IEntity {
    @Id
    @GeneratedValue
    @Column(name="id")
    private int id;
    @Column(name="category_id")
    private int categoryId;
    @Column(name="supplier_id")
    private int supplierId;
    @Column(name="product_name")
    private String productName;
    @Column(name="product_desc")
    private String productDescription;
    @Column(name="unit_price")
    private double unitPrice;
    @Column(name="units_in_stock")
    private double unitsInStock;


}
