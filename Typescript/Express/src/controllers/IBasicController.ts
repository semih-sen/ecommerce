import { RequestHandler } from "express";

export default interface IBasicController{
    getList:RequestHandler;
    add:RequestHandler;
    update:RequestHandler;
}