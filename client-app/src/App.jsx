import React, { useEffect } from "react";
import { BrowserRouter as Router, Route, Routes, useLocation } from "react-router-dom";
import Home from "./pages/Home";
import AdminDashboard from "./admin/Dashboard/AdminDashboard";
import SignUp from "./pages/sign-up/SignUp";
import SignIn from "./pages/sign-in/SignIn";

const App = () => {
  const location = useLocation();

  useEffect(() => {
    // Save the current path to local storage
    localStorage.setItem('currentPath', location.pathname);
  }, [location]);

  return (
    <Routes>
      <Route path="/" element={<Home />} />
      
      <Route path="/dashboard" element={<AdminDashboard />} /> {/* Home view redirects to Admin Dashboard */}
      <Route path="/admin/dashboard/users" element={<AdminDashboard />} /> {/* Users view */}
      <Route path="/admin/dashboard/news" element={<AdminDashboard />} /> {/* News view */}
      <Route path="/admin/dashboard/educators" element={<AdminDashboard />} /> {/* Educators view */}
      <Route path="/sign-in" element={<SignIn />} />
      <Route path="/sign-up" element={<SignUp />} />
    </Routes>
  );
};

const AppWrapper = () => (
  <Router>
    <App />
  </Router>
);

export default AppWrapper;