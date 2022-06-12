import express from "express";
import IBasicController from "../controllers/IBasicController";
import ProductsController from "../controllers/ProductsController";
const router:express.Router = express.Router();

const controller: IBasicController= new ProductsController();

router.get("/getAll",controller.getList);
router.post("/add",controller.add);
router.put("/:id/edit",controller.update);

export default router;