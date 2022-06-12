import {  ModelCtor,Model } from "sequelize/types";
import {DataTypes} from "sequelize";
import db from "../helpers/database/connectDatabase";
import IModel from "./IModel";

export interface IProduct extends IModel {
    categoryId:number;
    supplierId:number;
    productName:string;
    productDescription:string;
    unitPrice:number;
    unitsInStock:number;
}

const Product:ModelCtor<Model<IProduct | IModel,any>>= db.define('product',{
    categoryId:{
        type:DataTypes.INTEGER,
        field:"category_id"
    },
    supplierId:{
        type:DataTypes.INTEGER,
        field:"supplier_id"
    },
    productName: {
        type:DataTypes.STRING,
        field:"product_name"
    },
    productDescription: {
        type:DataTypes.STRING,
        field:"product_desc"
    },
    unitPrice: {
        type:DataTypes.DOUBLE,
        field:"unit_price"
    },
    unitsInStock: {
        type: DataTypes.DOUBLE,
        field:"units_in_stock"
    }
},{tableName:"products",createdAt:false,updatedAt:false,
    
})

export default Product;