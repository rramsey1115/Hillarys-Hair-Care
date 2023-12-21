import {Nav, NavItem, Navbar, NavbarBrand, NavLink} from "reactstrap"

export const Navigation = () => {
    return (
        <Navbar color="black" dark expand="sm">
            <Nav vertical>
                <NavbarBrand href="/">💈👱🏻‍♀️ Hillary's 💇🏻🪮 </NavbarBrand>
                <NavItem>
                    <NavLink href="/customers">Customers</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink href="/stylists">Stylists</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink href="/appointments">Appointments</NavLink>
                </NavItem>
            </Nav>
        </Navbar>
    )
}