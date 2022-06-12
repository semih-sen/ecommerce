import asyncHandler from "express-async-handler";
import User from "../models/User";
import BaseController from "./BaseController";
import IBasicController from "./IBasicController";


export default class UsersController extends BaseController implements IBasicController{

    constructor(){
        super(User)
    }
}