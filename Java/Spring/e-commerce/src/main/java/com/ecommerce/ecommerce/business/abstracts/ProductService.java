package com.ecommerce.ecommerce.business.abstracts;
import com.ecommerce.ecommerce.entities.concretes.Product;
import com.ecommerce.ecommerce.core.utilities.results.DataResult;
import java.util.List;

public interface ProductService {
    DataResult<List<Product>> getList();

}
