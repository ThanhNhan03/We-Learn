import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Home from "./pages/Home";
import AdminDashboard from "./admin/Dashboard/AdminDashboard";
import AdminAdd from "./admin/Dashboard/AdminAdd"; // Import AdminAdd component
import SignUp from "./pages/sign-up/SignUp"; // Import SignUp component
import SignIn from "./pages/sign-in/SignIn"; // Import SignIn component
function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} /> {/* Add route for Home */}
        <Route path="/admin/dashboard" element={<AdminDashboard />} />
        <Route path="/admin/add" element={<AdminAdd />} /> {/* Add route for AdminAdd */}
        <Route path="/sign-in" element={<SignIn/ >} /> {/* Add route for Register */}
        <Route path="/sign-up" element={<SignUp />} />
      </Routes>
    </Router>
  );
}

export default App;