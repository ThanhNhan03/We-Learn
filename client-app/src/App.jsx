import React, { useEffect } from "react";
import { BrowserRouter as Router, Route, Routes, useLocation } from "react-router-dom";
import CircularProgress from '@mui/material/CircularProgress';
import './components/style/WebStyle.css';
import SignUp from "./pages/sign-up/SignUp";
import SignIn from "./pages/sign-in/SignIn";
import CourseDetail from "./components/CourseDetail/CourseDetail";
import { UserProvider } from './contexts/UserContext';
import { AdminProvider } from './contexts/AdminContext';
import ErrorPage403 from "./pages/ErrorPage/ErrorPage403";
import ErrorPage404 from "./pages/ErrorPage/ErrorPage404";
import ErrorPage500 from "./pages/ErrorPage/ErrorPage500";
import ProtectedRoute from "./common/ProtectedRoute";
import ResetPassword from "./pages/ResetPassword/ResetPassword";
import AdminProfile from "./admin/Dashboard/components/AdminProfile";

const LazyGetStarted = React.lazy(() => import("./pages/GetStarted"));
const LazyHome = React.lazy(() => import("./pages/Home"));
const LazyAdminDashboard = React.lazy(() => import("./admin/Dashboard/AdminDashboard"));

// Spinner Component
const FallbackSpinner = () => (
  <div className="loading-spinner-container">
    <CircularProgress />
  </div>
);

const App = () => {
  const location = useLocation();

  useEffect(() => {
    // Save the current path to local storage
    localStorage.setItem('currentPath', location.pathname);
  }, [location]);

  return (
    <React.Suspense fallback={<FallbackSpinner />}>
      <Routes>
        <Route path="/" element={<LazyHome />} />
        <Route path="/sign-in" element={<SignIn />} />
        <Route path="/sign-up" element={<SignUp />} />
        <Route path="/get-started" element={<LazyGetStarted />} />
        <Route path="/course/:title" element={<CourseDetail />} />
        <Route path="/reset-password" element={<ResetPassword />} />

        <Route path="/admin/*" element={
          <ProtectedRoute>
            <Routes>
              <Route path="dashboard" element={<LazyAdminDashboard />} />
              <Route path="dashboard/users" element={<LazyAdminDashboard />} />
              <Route path="dashboard/news" element={<LazyAdminDashboard />} />
              <Route path="dashboard/educators" element={<LazyAdminDashboard />} />
              <Route path="profile" element={<AdminProfile/>} />
            </Routes>
          </ProtectedRoute>
        } />

        <Route path="/error-403" element={<ErrorPage403 />} />
        <Route path="/error-500" element={<ErrorPage500 />} />
        <Route path="*" element={<ErrorPage404 />} />
      </Routes>
    </React.Suspense>
  );
};

const AppWrapper = () => (
  <Router>
    <UserProvider>
      <AdminProvider>
        <App />
      </AdminProvider>
    </UserProvider>
  </Router>
);

export default AppWrapper;
