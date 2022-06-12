package com.ecommerce.ecommerce.dataAccess.abstracts;

import com.ecommerce.ecommerce.entities.concretes.Product;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductDao extends JpaRepository<Product,Integer> {
}
