import React, { useEffect } from "react";
import { BrowserRouter as Router, Route, Routes, useLocation } from "react-router-dom";
// import Home from "./pages/Home";
import AdminDashboard from "./admin/Dashboard/AdminDashboard";
import SignUp from "./pages/sign-up/SignUp";
import SignIn from "./pages/sign-in/SignIn";
import GetStarted from "./pages/GetStarted"; // Import GetStarted component 
import CourseDetail from "./components/CourseDetail/CourseDetail"; 
import CircularProgress from '@mui/material/CircularProgress';
import './components/style/WebStyle.css';
const LazyHome = React.lazy(() => import("./pages/Home"));
const App = () => {
  const location = useLocation();

  useEffect(() => {
    // Save the current path to local storage
    localStorage.setItem('currentPath', location.pathname);
  }, [location]);

  return (
    <Routes>
      <Route path="/" element={ 
        <React.Suspense fallback={ 
          <div className="loading-spinner-container">
            <CircularProgress />
          </div>
        }>
          <LazyHome />
        </React.Suspense>
        } 
        />
      <Route path="/admin/dashboard" element={<AdminDashboard />} /> {/* Home view redirects to Admin Dashboard */}
      <Route path="/admin/dashboard/users" element={<AdminDashboard />} /> {/* Users view */}
      <Route path="/admin/dashboard/news" element={<AdminDashboard />} /> {/* News view */}
      <Route path="/admin/dashboard/educators" element={<AdminDashboard />} /> {/* Educators view */}
      <Route path="/sign-in" element={<SignIn />} />
      <Route path="/sign-up" element={<SignUp />} />
      <Route path="/get-started" element={<GetStarted />} />  
      <Route path="/course/:title" element={<CourseDetail />} />
      
    </Routes>
  );  
};

const AppWrapper = () => (
  <Router>
    <App />
  </Router>
);

export default AppWrapper;