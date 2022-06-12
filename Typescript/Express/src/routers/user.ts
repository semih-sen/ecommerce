import express from "express";
import IBasicController from "../controllers/IBasicController";
import UsersController from "../controllers/UsersController";
const router:express.Router = express.Router();

const controller: IBasicController= new UsersController();

router.get("/getAll",controller.getList);
router.post("/register",controller.add);
router.post("/login",controller.add);
router.post("/logout",controller.add);
router.put("/:id/edit",controller.update);

export default router;