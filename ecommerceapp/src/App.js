import "./App.css";
import { Route, Routes } from "react-router-dom";
import Login from "./Pages/Login";
import SwitchMode from "./Components/SwitchMode";
import Home from "./Pages/Home";

function App() {
  return (
    <SwitchMode>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/Login" element={<Login />} />
      </Routes>
    </SwitchMode>
  );
}

export default App;
