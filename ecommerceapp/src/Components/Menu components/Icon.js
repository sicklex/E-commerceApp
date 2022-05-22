import React, { useState } from "react";
import { IconButton, Badge } from "@mui/material";
import AccountCircle from "@mui/icons-material/AccountCircle";
import MenuItem from "@mui/material/MenuItem";
import Menu from "@mui/material/Menu";
import FavoriteIcon from "@mui/icons-material/Favorite";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";

function Icon() {
  const [anchorEl, setAnchorEl] = useState(null);
  const handleLoginMenu = event => {
    anchorEl == null ? setAnchorEl(event.currentTarget) : setAnchorEl(null);
  };

  return (
    <div>
      <IconButton
        size="large"
        aria-controls="menu-appbar"
        aria-haspopup="true"
        onClick={handleLoginMenu}
        color="inherit"
      >
        <AccountCircle />
      </IconButton>
      <Menu
        id="login-appbar"
        anchorEl={anchorEl}
        anchorOrigin={{
          vertical: "bottom",
          horizontal: "right",
        }}
        keepMounted
        transformOrigin={{
          vertical: "top",
          horizontal: "right",
        }}
        open={Boolean(anchorEl)}
        onClose={handleLoginMenu}
      >
        <MenuItem onClick={handleLoginMenu}>Profile</MenuItem>
        <MenuItem onClick={handleLoginMenu}>My account</MenuItem>
      </Menu>
      <IconButton color="inherit">
        <Badge badgeContent={4} color="error">
          <FavoriteIcon />
        </Badge>
      </IconButton>

      <IconButton color="inherit">
        <Badge badgeContent={4} color="error">
          <ShoppingCartIcon />
        </Badge>
      </IconButton>
    </div>
  );
}

export default Icon;
