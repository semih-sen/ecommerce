package com.semih.ecommerce.dataAccess.abstract

import com.semih.ecommerce.entities.concrete.Product
import org.springframework.data.jpa.repository.JpaRepository

interface ProductDao : JpaRepository<Product,Long>{
}
