import React, { useEffect } from "react";
import { BrowserRouter as Router, Route, Routes, useLocation } from "react-router-dom";
// import AdminDashboard from "./admin/Dashboard/AdminDashboard";
import SignUp from "./pages/sign-up/SignUp";
import SignIn from "./pages/sign-in/SignIn";
import CourseDetail from "./components/CourseDetail/CourseDetail";
import CircularProgress from '@mui/material/CircularProgress';
import './components/style/WebStyle.css';

const LazyGetStarted = React.lazy(() => import("./pages/GetStarted"));
const LazyHome = React.lazy(() => import("./pages/Home"));
const LazyAdminDashboard = React.lazy(() => import("./admin/Dashboard/AdminDashboard"));

const App = () => {
  const location = useLocation();

  useEffect(() => {
    // Save the current path to local storage
    localStorage.setItem('currentPath', location.pathname);
  }, [location]);

  return (
    <Routes>
      {/* View Trang Home */}
      <Route 
        path="/" 
        element={ 
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyHome />
          </React.Suspense>
        } 
      />

      {/* View Dashboard của Admin */}
      <Route 
        path="/admin/dashboard"  
        element={ 
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyAdminDashboard/>
          </React.Suspense>
        }
      />

      {/* View user của Admin */}
      <Route 
        path="/admin/dashboard/users"  
        element={ 
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyAdminDashboard/>
          </React.Suspense>
        }
      />

      {/* View news của Admin */}
      <Route 
        path="/admin/dashboard/news"  
        element={
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyAdminDashboard />
          </React.Suspense>
        } 
      />

      {/* View educators của Admin */}
      <Route 
        path="/admin/dashboard/educators"  
        element={
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyAdminDashboard />
          </React.Suspense>
        } 
      />

      {/* View trang Sign-in */}
      <Route path="/sign-in" element={<SignIn />} /> 
      
      {/* View trang Sign-up */}
      <Route path="/sign-up" element={<SignUp />} /> 
      
      {/* View trang GetStarted */}
      <Route 
        path="/get-started"  
        element={ 
          <React.Suspense fallback={ 
            <div className="loading-spinner-container">
              <CircularProgress />
            </div>
          }>
            <LazyGetStarted />
          </React.Suspense>
        } 
      />
      
      {/* View trang CourseDetail */}
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