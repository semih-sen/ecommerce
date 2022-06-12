import express from "express";
import helmet from "helmet";
import cors from "cors";
import dotenv from "dotenv";
import router from "./routers/index"
import db from "./helpers/database/connectDatabase";

dotenv.config({
    path:"src/config/env/config.env"
})



const app:express.Application = express();

app.use(express.json());
app.use(cors());
app.use(helmet());
app.use("/api",router);

const PORT: string | undefined = process.env.PORT;
const NODE_ENV: string | undefined = process.env.NODE_ENV;

app.listen(PORT,()=>{
    console.log(`App started on ${PORT} and environment is ${NODE_ENV}`); 
});


