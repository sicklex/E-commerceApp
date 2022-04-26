import "./App.css";
import { Route, Routes } from "react-router-dom";
import Login from "./Pages/Login";
import Home from "./Pages/Home";
import MenuBar from "./Components/MenuBar";

function App() {
  return (
    <MenuBar>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/Login" element={<Login />} />
      </Routes>
    </MenuBar>
  );
}

export default App;
