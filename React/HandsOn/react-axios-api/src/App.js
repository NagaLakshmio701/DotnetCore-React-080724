
app.js

import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
// import HomePage from './Layout/HomePage';
import Login from './Authentication/Login';
import Header from './Layout/Header';
import Register  from './Authentication/Register';
import SearchBar from './Layout/SearchBar';
// import HomeContent from './Layout/HomeItems';
import Footer from './Layout/Footer';
import Logout from './Authentication/Logout';
import ViewCart  from './ViewCart';
import UserDashboard from './Dashboards/user-dashboard';
import Payment  from './Payments/payment';
import Profile from './Authentication/Profile';
import AdminDashboard  from './Dashboards/admin-dashboard';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<UserDashboard />} />
          <Route path="/login" element={<Login/>}/>
          <Route path="/register" element={<Register/>}/>
          <Route path="logout" element={<Logout/>}/>
          <Route path="/SearchBar" element={<SearchBar/>}/>
          <Route path="Footer" element={<Footer/>}/>
          <Route path="/profile" element={<Profile/>}/>           
            <Route path="ViewCart" element={<ViewCart />} />
            <Route path="tran" element={<Payment />} />








       </Route>
        


      
                





          
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;