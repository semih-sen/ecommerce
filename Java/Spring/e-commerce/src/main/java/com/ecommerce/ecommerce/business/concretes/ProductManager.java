package com.ecommerce.ecommerce.business.concretes;

import com.ecommerce.ecommerce.business.abstracts.ProductService;
import com.ecommerce.ecommerce.dataAccess.abstracts.ProductDao;
import com.ecommerce.ecommerce.entities.concretes.Product;
import  com.ecommerce.ecommerce.core.utilities.results.DataResult;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.ecommerce.ecommerce.core.utilities.results.SuccessDataResult;

import java.util.List;
@Service
public class ProductManager implements ProductService {
    private ProductDao productDao;
    @Autowired
    public ProductManager(ProductDao productDao) {
        this.productDao = productDao;
    }


    @Override
    public DataResult<List<Product>> getList() {
        return new SuccessDataResult<List<Product>>(this.productDao.findAll());
    }
}
