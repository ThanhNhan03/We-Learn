import React, { useContext } from 'react';
import { Navigate } from 'react-router-dom';
import { AdminContext } from '../contexts/AdminContext';
import { UserContext } from '../contexts/UserContext';

const ProtectedRoute = ({ children }) => {
  const { admin, isAdmin, isTeacher } = useContext(AdminContext);
//   const { user } = useContext(UserContext);

  console.log('Admin context:', admin);

  if (!admin  ) {
    return <Navigate to="/error-403" replace />;
  }

  if (admin && (isAdmin() || isTeacher())) {
    return children;
  }


};

export default ProtectedRoute;