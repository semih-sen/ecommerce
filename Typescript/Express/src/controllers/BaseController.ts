import IBasicController from "./IBasicController";
import asyncHandler from "express-async-handler";
import { Model, ModelCtor } from "sequelize/types";
import IModel from "../models/IModel";
import _ from "underscore";

export default class BaseController implements IBasicController {

  _model:ModelCtor<Model<IModel,any>>
  constructor(model:ModelCtor<Model<IModel,any>>){
      this._model=model;
      this.getList= this.getList.bind(this);
      this.add=this.add.bind(this);
  }
  getList = asyncHandler(async (req, res) => {
      let objects = await this._model.findAll();
      res.status(200).json({
          success:true,
          message: "List of objects",
          data: objects
      });
  });
  
  add = asyncHandler(async (req, res) =>{
    let body = req.body;
    let object = await this._model.create({
        ...body,
    });
    res.status(200).json({
        success:true,
        message:"Successfully added",
        data:object
    });
  })

  update= asyncHandler(async (req, res) => {
      let body = req.body;
      let id = req.params.id;
      let object = await this._model.findByPk(id) as Model<IModel,any> & any;
      let keys = _.keys(body);
      for (let i: number = 0; i < keys.length; i++) {
        object[keys[i]] = body[keys[i]];
      }
      await object.save();
      res.status(200).json({
        success: true,
        data:object,
      });
  })
}
