import React, { useMemo, useState } from "react";
import {
  createTheme,
  ThemeProvider,
  CssBaseline,
  AppBar,
  Toolbar,
  Typography,
  IconButton,
  Menu,
  MenuItem,
} from "@mui/material";
import { Box } from "@mui/system";
import Brightness4Icon from "@mui/icons-material/Brightness4";
import Brightness7Icon from "@mui/icons-material/Brightness7";
import SwipeableTemporaryDrawer from "./Drawer";
import useMediaQuery from "@mui/material/useMediaQuery";
import MenuIcon from "@mui/icons-material/Menu";
import Icon from "./Menu components/Icon";
import AccountCircle from "@mui/icons-material/AccountCircle";
import FavoriteIcon from "@mui/icons-material/Favorite";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";
import SearchBar from "./Menu components/SearchBar";

function MenuBar({ children }) {
  const [mode, setMode] = useState("light");
  const [anchorEl, setAnchorEl] = useState(null);
  const colorMode = useMemo(
    () => ({
      toggleColorMode: () => {
        setMode(prevMode => (prevMode === "light" ? "dark" : "light"));
      },
    }),
    []
  );

  const theme = useMemo(
    () =>
      createTheme({
        palette: {
          mode,
        },
      }),
    [mode]
  );
  const handleLoginMenu = event => {
    anchorEl == null ? setAnchorEl(event.currentTarget) : setAnchorEl(null);
  };
  const isActive = useMediaQuery("(min-width:675px)");
  const test = useMediaQuery("(min-width:600px)");
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Box>
        <AppBar
          position="static"
          sx={{
            display: "flex",
            justifyContent: "center",
          }}
        >
          <Toolbar>
            <SwipeableTemporaryDrawer />
            {test && (
              <Typography variant="h7" component="div" sx={{ flexGrow: 1 }}>
                Dev ECommerce
              </Typography>
            )}
            <SearchBar />
            {isActive ? (
              <Icon></Icon>
            ) : (
              <>
                <MenuIcon onClick={handleLoginMenu}></MenuIcon>
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
                  <MenuItem onClick={handleLoginMenu}>
                    <AccountCircle />
                    Login
                  </MenuItem>
                  <MenuItem onClick={handleLoginMenu}>
                    {" "}
                    <FavoriteIcon />
                    Favorites
                  </MenuItem>
                  <MenuItem onClick={handleLoginMenu}>
                    <ShoppingCartIcon />
                    Cards
                  </MenuItem>
                </Menu>
              </>
            )}
            <IconButton
              sx={{ ml: 2 }}
              onClick={colorMode.toggleColorMode}
              color="inherit"
            >
              {theme.palette.mode === "dark" ? (
                <Brightness7Icon />
              ) : (
                <Brightness4Icon />
              )}
            </IconButton>
          </Toolbar>
        </AppBar>
      </Box>
      {children}
    </ThemeProvider>
  );
}

export default MenuBar;
