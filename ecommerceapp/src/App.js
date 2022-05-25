import "./App.css";
import { Route, Routes } from "react-router-dom";
import Login from "./Pages/Login";
import Home from "./Pages/Home";
import MenuBar from "./Components/MenuBar";
import Product from "./Pages/Product";

function App() {
  return (
    <MenuBar>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/Login" element={<Login />} />
        <Route path="/products/:id" element={<Product />} />
      </Routes>
    </MenuBar>
  );
}

export default App;
