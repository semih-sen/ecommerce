import asyncHandler from "express-async-handler";
import Product from "../models/Product";
import BaseController from "./BaseController";
import IBasicController from "./IBasicController";


export default class ProductsController extends BaseController implements IBasicController{

    constructor(){
        super(Product)
    }
}