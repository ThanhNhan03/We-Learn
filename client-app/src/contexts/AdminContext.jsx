import React, { createContext, useState, useEffect } from 'react';

export const AdminContext = createContext();

export const AdminProvider = ({ children }) => {
  const [admin, setAdmin] = useState(() => {
    const storedAdmin = localStorage.getItem('admin');
    return storedAdmin ? JSON.parse(storedAdmin) : null;
  });

  useEffect(() => {
    if (admin) {
      localStorage.setItem('admin', JSON.stringify(admin));
    } else {
      localStorage.removeItem('admin');
    }
  }, [admin]);

  const login = (adminData) => {
    try {
      setAdmin(adminData);
    } catch (error) {
      console.error('Failed to login:', error);
      
    }
  };

  const logout = () => {
    try {
      setAdmin(null);
      localStorage.removeItem('admin');
  
    } catch (error) {
      console.error('Failed to logout:', error);

    }
  };

  const isAdmin = () => admin?.role === 'Admin';
  const isTeacher = () => admin?.role === 'Teacher';

  return (
    <AdminContext.Provider value={{ admin, login, logout, isAdmin, isTeacher }}>
      {children}
    </AdminContext.Provider>
  );
};
