import {  ModelCtor,Model } from "sequelize/types";
import {DataTypes} from "sequelize";
import db from "../helpers/database/connectDatabase";
import IModel from "./IModel";

export interface IUser{
    userName:string;
    email:string;
    firstName:string;
    lastName:string;
    role:number;
    password:string;
}

const Product:ModelCtor<Model<IUser | IModel,any>>= db.define('user',{
    userName:{
        type:DataTypes.STRING,
        field:"user_name"
    },
    email:{
        type:DataTypes.STRING,
        field:"email"
    },
    firstName: {
        type:DataTypes.STRING,
        field:"first_name"
    },
    lastName: {
        type:DataTypes.STRING,
        field:"last_name"
    },
    role: {
        type:DataTypes.INTEGER,
        field:"role"
    },
    password: {
        type: DataTypes.STRING,
        field:"password"
    }
},{tableName:"users",createdAt:true,updatedAt:false,
    
})

export default Product;