package com.semih.ecommerce.entities.concrete

import javax.persistence.*

@Entity
@Table(name="products")
data class Product(
    @Id @GeneratedValue @Column(name="id") val id:Long?,
    @Column(name = "category_id") val categoryId: Long,
    @Column(name="supplier_id") val supplierId:Long,
    @Column(name="product_name") val productName:String,
    @Column(name="product_desc") val productDescription:String,
    @Column(name="unit_price") val unitPrice:Double,
    @Column(name="units_in_stock") val unitsInStock:Double
)
