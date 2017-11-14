/*
 * Created by Provindex, Inc.
 * User: Jason Banks
 * Date: 10/6/2016
 * Time: 4:18 PM
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProdVisions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("prodvisions v1.0");
            Console.WriteLine("Powered by Provindex, Inc.");
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

            Menu initial = new Menu();

            string selection = initial.main_menu();

            initial.selection_switch(selection);
        }
    }

    class Menu
    {
        public string main_menu()
        {
            Console.Clear();
            Console.WriteLine("prodvisions v1.0");
            Console.WriteLine("Powered by Provindex, Inc.");
            Console.WriteLine("----------");
            Console.WriteLine("Select a design element from the main menu:");
            Console.WriteLine("----------");
            Console.WriteLine("1. Checkbox");
            Console.WriteLine("2. Radio");
            Console.WriteLine("3. Drop Down Menu");
            Console.WriteLine("4. List Box");
            Console.WriteLine("5. Button");
            Console.WriteLine("6. Drop Down Button");
            Console.WriteLine("7. Toggle Switch");
            Console.WriteLine("8. Text");
            Console.WriteLine("9. Date and Time");
            Console.WriteLine("10. Search");
            Console.WriteLine("11. Breadcrumbs");
            Console.WriteLine("12. Pagination");
            Console.WriteLine("13. Tags - FULL VERSION ONLY");
            Console.WriteLine("14. Sliders");
            Console.WriteLine("15. Icons");
            Console.WriteLine("16. Image Carousel - FULL VERSION ONLY");
            Console.WriteLine("17. Notifications");
            Console.WriteLine("18. Progress Bar");
            Console.WriteLine("19. Tool Tips");
            Console.WriteLine("20. Message Box");
            Console.WriteLine("21. Modal");
            Console.WriteLine("22. Accordion");
            Console.WriteLine("23. HTML Elements");
            Console.WriteLine("24. Exit prodvisions.");

            Console.WriteLine("----------");
            Console.Write("pv: ");
            string design_element = Console.ReadLine();

            return design_element;
        }

        public void selection_switch(string pick)
        {
            int x = Convert.ToInt32(pick);

            switch (x)
            {
                case 1:
                    Checkbox checkbox = new Checkbox();
                    Console.Write("Enter the name of your checkbox set: ");
                    string cb_name = Console.ReadLine();
                    Console.Write("Enter the names of your checkboxes, delimited with a comma: ");
                    string cb_list = Console.ReadLine();
                    checkbox.checkbox_list(cb_list, cb_name);

                    Menu initial = new Menu();

                    string selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 2:
                    Radio radio = new Radio();
                    Console.Write("Enter the name of your radio set: ");
                    string r_name = Console.ReadLine();
                    Console.Write("Enter the names of your radios, delimited with a comma: ");
                    string r_list = Console.ReadLine();
                    radio.radio_selections(r_list, r_name);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 3:
                    DropDownMenu ddm = new DropDownMenu();
                    Console.Write("Enter the name of your menu: ");
                    string ddm_name = Console.ReadLine();
                    Console.Write("Enter the options of your menu, delimited with a comma: ");
                    string ddm_list = Console.ReadLine();
                    ddm.menu_options(ddm_list, ddm_name);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 4:
                    ListBox lb = new ListBox();
                    Console.Write("Enter the name of your list box: ");
                    string lb_name = Console.ReadLine();
                    Console.Write("Enter the options of your list box, delimited with a comma: ");
                    string lb_list = Console.ReadLine();
                    Console.Write("Enter the size of your list box, based on rows: ");
                    string lb_size = Console.ReadLine();
                    int lb_size_int = Convert.ToInt32(lb_size);
                    lb.listbox_options(lb_list, lb_name, lb_size_int);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 5:
                    Button b = new Button();
                    Console.Write("Enter the type of button (image, reset, standard, submit): ");
                    string b_type = Console.ReadLine();

                    if (b_type == "image")
                    {
                        Console.Write("What should the name of the image button? ");
                        string image_name = Console.ReadLine();

                        Console.Write("What is the image filename? ");
                        string image_directory = Console.ReadLine();

                        b.image(image_name, image_directory);

                        initial = new Menu();

                        selection = initial.main_menu();

                        initial.selection_switch(selection);
                    }

                    else if (b_type == "reset")
                    {
                        Console.Write("What is the name of the Reset button? ");
                        string reset_name = Console.ReadLine();

                        Console.Write("What should the name of the Reset button be? ");
                        string reset_value = Console.ReadLine();

                        b.reset(reset_name, reset_value);

                        initial = new Menu();

                        selection = initial.main_menu();

                        initial.selection_switch(selection);

                    }

                    else if (b_type == "standard")
                    {
                        Console.Write("What is the name of this button?");
                        string button_value = Console.ReadLine();

                        Console.Write("What should the message say?");
                        string button_message = Console.ReadLine();

                        b.standard_button(button_value, button_message);

                        initial = new Menu();

                        selection = initial.main_menu();

                        initial.selection_switch(selection);
                    }

                    else
                    {
                        Console.Write("What should the name of the Submit button be?");
                        string submit_name = Console.ReadLine();

                        b.submit(submit_name);

                        initial = new Menu();

                        selection = initial.main_menu();

                        initial.selection_switch(selection);
                    }

                    break;

                case 6:
                    DropDownButton ddb = new DropDownButton();
                    Console.Write("Enter the name of your drop down button: ");
                    string ddb_name = Console.ReadLine();
                    Console.Write("What should the Drop Down Button say? ");
                    string ddb_button_name = Console.ReadLine();
                    Console.Write("What is the name of the list? ");
                    string ddb_list_name = Console.ReadLine();
                    Console.Write("What is the ID of the list? ");
                    string ddb_list_id = Console.ReadLine();
                    Console.Write("What are the list of addresses, separated by commas? ");
                    string ddb_addresslist = Console.ReadLine();
                    Console.Write("What are the list of addresses text, separated by commas? ");
                    string ddb_addresslistnames = Console.ReadLine();

                    Console.WriteLine(ddb.ddb_html_and_css(ddb_name, ddb_button_name, ddb_list_name, ddb_list_id, ddb_addresslist, ddb_addresslistnames));
                    Console.WriteLine(ddb.ddb_js(ddb_list_id, ddb_list_name));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 7:
                    ToggleSwitch t = new ToggleSwitch();
                    Console.Write("What is the name of this toggle? ");
                    string t_value = Console.ReadLine();

                    Console.Write("Circle or square? ");
                    string t_shape = Console.ReadLine();

                    t.ts_html(t_value, t_shape);

                    Console.WriteLine("----------");
                    Console.WriteLine("CSS: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(t.ts_css(t_value));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 8:
                    TextBox tb = new TextBox();
                    Console.Write("field or area? ");
                    string tb_type = Console.ReadLine();
                    Console.Write("What is the name of the text field? ");
                    string tb_name = Console.ReadLine();

                    if (tb_name == "field")
                    {
                        Console.Write("What is the value of the text field? ");
                        string tb_value = Console.ReadLine();
                        Console.Write("Type 'y' if this text field is read-only. ");
                        string tb_read = Console.ReadLine();
                        Console.Write("Type 'y' if this text field is disabled. ");
                        string tb_disabled = Console.ReadLine();
                        Console.Write("What is the size, in characters? ");
                        string tb_size = Console.ReadLine();
                        Console.Write("What is the maximum length? ");
                        string tb_maxlength = Console.ReadLine();

                        int tb_size_int = Convert.ToInt32(tb_size);
                        int tb_maxlength_int = Convert.ToInt32(tb_maxlength);

                        tb.text_field(tb_name, tb_value, tb_read, tb_disabled, tb_size_int, tb_maxlength_int);
                    }

                    else
                    {
                        Console.Write("How many rows? ");
                        string tb_rows = Console.ReadLine();
                        int tb_rows_int = Convert.ToInt32(tb_rows);
                        Console.Write("How many columns? ");
                        string tb_cols = Console.ReadLine();
                        int tb_cols_int = Convert.ToInt32(tb_cols);
                        Console.Write("What is the message? ");
                        string tb_message = Console.ReadLine();

                        tb.text_area(tb_name, tb_rows_int, tb_cols_int, tb_message);
                    }

                    break;

                case 9:
                    DateTime dt = new DateTime();
                    Console.Write("What is the name of this element? ");
                    string dt_name = Console.ReadLine();
                    Console.WriteLine("Select the number to use to create this element: ");
                    Console.WriteLine("----------");
                    Console.WriteLine("1. Date");
                    Console.WriteLine("2. Date and Time");
                    Console.WriteLine("3. Local Date and Time");
                    Console.WriteLine("4. Month");
                    Console.WriteLine("5. Time");
                    Console.WriteLine("6. Week");
                    Console.Write("pv: ");
                    string dt_metric = Console.ReadLine();
                    int dt_number = Convert.ToInt32(dt_metric);

                    switch (dt_number)
                    {
                        case 1:
                            dt.date(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;

                        case 2:
                            dt.datetime(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;

                        case 3:
                            dt.datetimelocal(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;

                        case 4:
                            dt.month(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;

                        case 5:
                            dt.time(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;

                        case 6:
                            dt.week(dt_name);

                            Console.WriteLine("----------");
                            Console.WriteLine("Press any key to return to the main menu...");
                            Console.ReadKey(true);

                            initial = new Menu();

                            selection = initial.main_menu();

                            initial.selection_switch(selection);

                            break;
                        default:

                            break;
                    }

                    break;

                case 10:
                    Search s = new Search();
                    Console.Write("What is the name of the search bar? ");
                    string s_id = Console.ReadLine();
                    s.build_url(s_id);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 11:
                    Breadcrumbs bc = new Breadcrumbs();
                    Console.Write("What is the name of the Breadcrumb? ");
                    string bc_name = Console.ReadLine();
                    Console.Write("What is the location trail of the Breadcrumb, separated by commas? ");
                    string bc_list = Console.ReadLine();
                    Console.Write("What are the corresponding addresses of each page of the location trail, separated by commas? ");
                    string bc_addresses = Console.ReadLine();
                    Console.Write("What is the name of current location in the Breadcrumb? ");
                    string bc_current = Console.ReadLine();

                    bc.breadcrumbs_html(bc_name, bc_addresses, bc_list, bc_current);

                    Console.WriteLine("----------");
                    Console.WriteLine("CSS: ");
                    Console.WriteLine("-----------");

                    bc.breadcrumbs_css(bc_name);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 12:
                    PageTurner pt = new PageTurner();

                    Console.Write("What is the name of the Pagination? ");
                    string pt_name = Console.ReadLine();
                    Console.Write("What are the numberos of each corresponding page, separated by commas? ");
                    string pt_list = Console.ReadLine();
                    Console.Write("What are the addresses of each page, separated by commas? ");
                    string pt_addresses = Console.ReadLine();
                    Console.Write("What number is the active page? ");
                    string pt_active = Console.ReadLine();
                    int pt_active_int = Convert.ToInt32(pt_active);
                    Console.Write("What should the next page button look like? ");
                    string pt_next = Console.ReadLine();
                    Console.Write("What should the previous page button look like? ");
                    string pt_prev = Console.ReadLine();

                    pt.pageturner_html(pt_name, pt_addresses, pt_list, pt_active_int, pt_prev, pt_next);

                    Console.WriteLine("----------");
                    Console.WriteLine("CSS: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(pt.pageturner_css(pt_name));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 13:
                    break;

                case 14:
                    Slider slider = new Slider();

                    Console.Write("What is the name of the Slider? ");
                    string s_name = Console.ReadLine();
                    Console.Write("What is the minimum value? ");
                    string s_min = Console.ReadLine();
                    Console.Write("What is the maximum value? ");
                    string s_max = Console.ReadLine();
                    Console.Write("What value should the Slider be set to? ");
                    string s_setting = Console.ReadLine();
                    //int pt_active_int = Convert.ToInt32(pt_active);
                    Console.Write("How much should the value increment? ");
                    string s_step = Console.ReadLine();

                    slider.slider_html(s_name, s_min, s_max, s_setting, s_step);

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(slider.slider_js(s_name));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);


                    break;

                case 15:
                    EssentialIcons ei = new EssentialIcons();

                    Console.Write("What is the name of the icon? ");
                    string ei_icon = Console.ReadLine();
                    Console.Write("What is the name of your project? ");
                    string ei_project_name = Console.ReadLine();
                    Console.Write("What is the height of the icon? ");
                    string ei_height = Console.ReadLine();
                    Console.Write("What is the width of the icon? ");
                    string ei_width = Console.ReadLine();

                    ei.copy_icons(ei_icon, ei_project_name);
                    ei.icon_html(ei_icon, ei_height, ei_width);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 16:

                    break;

                case 17:
                    Notifications notify = new Notifications();

                    Console.Write("What is the name of the button? ");
                    string notify_button_name = Console.ReadLine();
                    Console.Write("What is the title of the notification? ");
                    string notify_title = Console.ReadLine();
                    Console.Write("What is the name of the tag for this notification? ");
                    string notify_tag = Console.ReadLine();
                    Console.Write("What is the name of the icon for this notification? ");
                    string notify_icon_name = Console.ReadLine();
                    Console.Write("What is the name of the project? ");
                    string notify_project_name = Console.ReadLine();
                    Console.Write("What is the message? ");
                    string notify_message = Console.ReadLine();

                    notify.notify_html(notify_button_name);

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(notify.notify_js(notify_title, notify_tag, notify_icon_name, notify_project_name, notify_message));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 18:
                    ProgressBar pb = new ProgressBar();

                    Console.Write("What is the name of the progress bar? ");
                    string pb_id = Console.ReadLine();
                    Console.Write("What is the max value of the progress bar? ");
                    string pb_max = Console.ReadLine();

                    pb.progress_html(pb_id, pb_max);

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(pb.progress_js(pb_id, pb_max));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 19:

                    ToolTip tt = new ToolTip();

                    Console.Write("What is the name of the tool tip? ");
                    string tt_id = Console.ReadLine();
                    Console.Write("What is the caption of the tool tip? ");
                    string tt_caption = Console.ReadLine();
                    Console.Write("What is the text of the tool tip? ");
                    string tt_text = Console.ReadLine();

                    tt.tooltip_html(tt_id, tt_caption, tt_text);

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(tt.tooltip_js(tt_id));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 20:
                    MessageBox mb = new MessageBox();

                    Console.Write("What is the name of the message box button? ");
                    string mb_text = Console.ReadLine();
                    Console.Write("What is the message? ");
                    string mb_message = Console.ReadLine();

                    mb.messagebox_html(mb_text);

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    mb.messagebox_js(mb_message);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 21:

                    Modal modal = new Modal();

                    Console.Write("What is the name of the button? ");
                    string modal_button_name = Console.ReadLine();
                    Console.Write("What is the name of the label on the button? ");
                    string modal_button_label = Console.ReadLine();
                    Console.Write("What is the id of the modal? ");
                    string modal_id = Console.ReadLine();
                    Console.Write("What is the text in the modal? ");
                    string modal_text = Console.ReadLine();

                    modal.modal_html(modal_button_name, modal_button_label, modal_id, modal_text);

                    Console.WriteLine("----------");
                    Console.WriteLine("CSS: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(modal.modal_css());

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(modal.modal_js(modal_id, modal_button_name));

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
                case 22:

                    Container contain = new Container();

                    Console.Write("What are the section names, separated by a semicolon? ");
                    string contain_section_names = Console.ReadLine();
                    Console.Write("What are the respective section texts, separated by semicolon? ");
                    string contain_section_texts = Console.ReadLine();

                    contain.container_html(contain_section_names, contain_section_texts);

                    Console.WriteLine("----------");
                    Console.WriteLine("CSS: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(contain.container_css());

                    Console.WriteLine("----------");
                    Console.WriteLine("JavaScript: ");
                    Console.WriteLine("-----------");

                    Console.WriteLine(contain.container_js());

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 23:
                    Console.WriteLine("----------");
                    Console.WriteLine("Select a HTML element:");
                    Console.WriteLine("----------");
                    Console.WriteLine("1. Heading");
                    Console.WriteLine("2. Paragraph");
                    Console.WriteLine("3. Line Break");
                    Console.WriteLine("4. Space");

                    break;
                case 24:
                    Environment.Exit(0);
                    break;

                default:
                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;
            }
        }
    }

    class Checkbox
    {
        public void checkbox_list(string checkboxlist, string name)
        {
            string[] words = checkboxlist.Split(',');
            foreach (string word in words)
            {
                Console.WriteLine("<input type='checkbox' name='" + name + "' value='" + word + "'>" + word + "<br>");

            }
        }
    }

    class Radio
    {
        public void radio_selections(string options, string name)
        {
            string[] words = options.Split(',');
            foreach (string word in words)
            {
                Console.WriteLine("<input type='radio' name='" + name + "' value='" + word + "'>" + word + "<br>");
            }
        }
    }

    class DropDownMenu
    {
        public void menu_options(string options, string name)
        {
            string[] words = options.Split(',');

            Console.WriteLine("<select name='" + name + "'>");

            foreach (string word in words)
            {
                Console.WriteLine("<option value='" + word + "'>" + word + "</option>");
            }

            Console.WriteLine("</select>");
        }
    }

    class ListBox
    {
        public void listbox_options(string options, string name, int size)
        {
            string[] words = options.Split(',');

            Console.WriteLine("<select name='" + name + "' size='" + size + "'>");

            foreach (string word in words)
            {
                Console.WriteLine("<option value='" + word + "'>" + word + "</option>");
            }

            Console.WriteLine("</select>");
        }

    }

    class Button
    {
        public void submit(string value)
        {
            Console.WriteLine("<input type='submit' value='" + value + "'>");
        }


        //This button returns the JavaScript needed to display the message in a popup
        public void standard_button(string value, string message)
        {
            Console.WriteLine("<input type='button' value='" + value + "' onclick='msg()'>");

            Console.WriteLine("----------");
            Console.WriteLine("JavaScript: ");
            Console.WriteLine("-----------");
            Console.WriteLine(standard_button_js(message));
        }

        public string standard_button_js(string message)
        {
            string js_string;

            js_string = "<script>function msg() {alert('" + message + "');}</script>";

            return js_string;
        }

        public void reset(string name, string value)
        {
            Console.WriteLine("<input type='reset' name='" + name + "'  value='" + value + "' />");
        }

        public void image(string name, string source)
        {
            Console.WriteLine("<input type='image' name='" + name + "' src='" + source + "' />");
        }
    }

    class DropDownButton
    {
        public string ddb_html_and_css(string ddb_name, string ddb_button_name, string ddb_list_name, string ddb_id, string addresslist, string addresslistnames)
        {
            string[] words_addresses = addresslist.Split(',');
            string[] words_names = addresslistnames.Split(',');
            int count = 0;

            Console.WriteLine("<div class='" + ddb_name + "'>");
            Console.WriteLine("<button onclick='myFunction()' class='" + ddb_button_name + "'>" + ddb_button_name + "</button>");
            Console.WriteLine("<div id='" + ddb_id + "' class='" + ddb_list_name + "'>");

            foreach (string word in words_addresses)
            {
                Console.WriteLine("<a href='" + word + "'>" + words_names[count] + "</a>");
                count++;
            }

            Console.WriteLine("</div>");
            Console.WriteLine("</div>");

            Console.WriteLine("----------");
            Console.WriteLine("CSS: ");
            Console.WriteLine("-----------");

            string css_string = "<style>." + ddb_button_name + " {background-color: #4CAF50;color: white;padding: 16px;font-size: 16px;border: none;cursor: pointer;}";
            css_string += "." + ddb_button_name + ":hover, ." + ddb_button_name + ":focus {background-color: #3e8e41;}";
            css_string += "." + ddb_name + " {position: relative;display: inline-block;}";
            css_string += "." + ddb_list_name + " {display: none;position: absolute;background-color: #f9f9f9;min-width: 160px;overflow: auto;box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);";
            css_string += "." + ddb_list_name + " a {color: black;padding: 12px 16px;text-decoration: none;display: block;}";
            css_string += "." + ddb_name + "a:hover {background-color: #f1f1f1}";
            css_string += ".show {display:block;}</style>";
            return css_string;
        }

        public string ddb_js(string ddb_id, string ddb_list_name)
        {
            Console.WriteLine("----------");
            Console.WriteLine("JavaScript: ");
            Console.WriteLine("-----------");

            string js_string = "<script>function myFunction() { document.getElementById('" + ddb_id + "').classList.toggle('show'); } var dropdowns = document.getElementsByClassName('" + ddb_list_name + "'); var i; for (i = 0; i < dropdowns.length; i++) {var openDropdown = dropdowns[i]; if (openDropdown.classList.contains('show')) {openDropdown.classList.remove('show');}}}}</script>";
            return js_string;
        }
    }

    class ToggleSwitch
    {
        public void ts_html(string name, string shape)
        {
            Console.WriteLine("<label class='" + name + "'>");
            Console.WriteLine("<input type='checkbox'>");

            if (shape == "round")
            {
                Console.WriteLine("<div class='slider " + shape + "'></div>");
            }

            else Console.WriteLine("<div class='slider'></div>");
            Console.WriteLine("</label>");
        }

        public string ts_css(string name)
        {
            string css_string = "<style>." + name + " {position: relative;display: inline-block;width: 60px;height: 34px;}";
            css_string += "." + name + " input {display:none;}";
            css_string += ".slider {position: absolute;cursor: pointer;top: 0;left: 0;right: 0;bottom: 0;background-color: #ccc;-webkit-transition: .4s;transition: .4s;}";
            css_string += ".slider:before {position: absolute;content: \"\";height: 26px;width: 26px;left: 4px;bottom: 4px;background-color: white;-webkit-transition: .4s;transition: .4s;}";
            css_string += "input:checked + .slider {background-color: #2196F3;}";
            css_string += "input:focus + .slider {box-shadow: 0 0 1px #2196F3;}";
            css_string += "input:checked + .slider:before {-webkit-transform: translateX(26px);-ms-transform: translateX(26px);transform: translateX(26px);}";
            css_string += ".slider.round {border-radius: 34px;}.slider.round:before {border-radius: 50%;}</style>";

            return css_string;
        }
    }

    class TextBox
    {
        public void text_field(string name, string value, string read, string disabled, int size, int maxlength)
        {
            string tf_string = "<input type='text' name='" + name + "' value='" + value + "' size='" + size + "' maxlength='" + maxlength + "'>";

            if (read != "")
            {
                tf_string = "<input type='text' name='" + name + "' value='" + value + "' size='" + size + "' maxlength='" + maxlength + "' readonly>";
            }

            if (disabled != "")
            {
                tf_string = "<input type='text' name='" + name + "' value='" + value + "' size='" + size + "' maxlength='" + maxlength + "' disabled>";
            }

            if (read != "" && disabled != "")
            {
                tf_string = "<input type='text' name='" + name + "' value='" + value + "' size='" + size + "' maxlength='" + maxlength + "'readonly disabled>";
            }
            Console.WriteLine(tf_string);
        }

        public void text_area(string name, int rows, int cols, string message)
        {
            Console.WriteLine("<textarea name='" + name + "' rows='" + rows + "' cols='" + cols + "'>");
            Console.WriteLine(message);
            Console.WriteLine("</textarea>");
        }
    }

    class DateTime
    {
        public void date(string name)
        {
            Console.WriteLine("<input type='date' name='" + name + "'>");
        }

        public void datetime(string name)
        {
            Console.WriteLine("<input type='datetime' name='" + name + "'>");
        }

        public void datetimelocal(string name)
        {
            Console.WriteLine("<input type='datetime-local' name='" + name + "'>");
        }

        public void month(string name)
        {
            Console.WriteLine("<input type='month' name='" + name + "'>");
        }

        public void time(string name)
        {
            Console.WriteLine("<input type='time' name='" + name + "'>");
        }

        public void week(string name)
        {
            Console.WriteLine("<input type='week' name='" + name + "'>");
        }
    }

    class Search
    {
        public void build_url(string id)
        {
            Console.WriteLine("<form id='" + id + "' method='get' action='https://www.duckduckgo.com'>");
            Console.WriteLine("<input type='search' name='q' size='21' maxlength='120'><input type='submit' value='search'>");
            Console.WriteLine("</form>");
        }
    }

    class Breadcrumbs
    {
        public string breadcrumbs_css(string classname)
        {
            string css_string = "<style>ul." + classname + " {padding: 8px 16px;list-style: none;background-color: #eee;}";
            css_string += "ul." + classname + " li {display: inline;}";
            css_string += "ul." + classname + " li+li:before {padding: 8px;color: black;content: '>\00a0';}";
            css_string += "ul." + classname + " li a {color: green;}</style>";

            return css_string;
        }

        public void breadcrumbs_html(string classname, string bc_addresses, string bc_list, string bc_current)
        {
            Console.WriteLine("<ul class='" + classname + "'>");

            string[] words_addresses = bc_addresses.Split(',');
            string[] words_names = bc_list.Split(',');
            int count = 0;

            foreach (string word in words_addresses)
            {
                Console.WriteLine("<li><a href='" + word + "'>" + words_names[count] + "</a></li>");
                count++;
            }

            Console.WriteLine("<li>" + bc_current + "</li>");
            Console.WriteLine("</ul>");
        }
    }

    class PageTurner
    {
        public void pageturner_html(string classname, string pt_addresses, string pt_list, int active, string pt_back, string pt_forward)
        {
            Console.WriteLine("<ul class='" + classname + "'>");

            string[] words_addresses = pt_addresses.Split(',');
            string[] words_names = pt_list.Split(',');
            int count = 0;

            Console.WriteLine("<li><a href='" + pt_back + "'>&laquo;</a></li>");

            foreach (string word in words_addresses)
            {

                int active_count = active - 1;
                if (active_count == count)
                {
                    Console.WriteLine("<li><a class='active' href='" + word + "'>" + active + "</a></li>");
                    count++;
                }

                else
                {
                    int pt_count = count + 1;
                    Console.WriteLine("<li><a href='" + word + "'>" + pt_count + "</a></li>");
                    count++;
                }

            }

            Console.WriteLine("<li><a href='" + pt_forward + "'>&lraquo;</a></li>");
            Console.WriteLine("</ul>");
        }

        public string pageturner_css(string classname)
        {
            string css_string = "<style>ul." + classname + " {display: inline-block;padding: 0;margin: 0;}";
            css_string += "ul." + classname + " li {display: inline;}";
            css_string += "ul." + classname + " li a {color: black;float: left;padding: 8px 16px;text-decoration: none;transition: background-color .3s;}";
            css_string += "ul." + classname + " li a.active {background-color: #4CAF50;color: white;}";
            css_string += "ul." + classname + " li a:hover:not(.active) {background-color: #ddd;}</style>";

            return css_string;
        }
    }

    class Tagtastic
    {
        public void createdatabase()
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("tagtasticdb.txt");

                //Write a line of text
                sw.WriteLine("id;url;tags;");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void addtags(string url, string tags)
        {
            int id = 0;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("tagtasticdb.txt");

                //Read the first line of text - read twice to skip header
                string line = sr.ReadLine();
                line = sr.ReadLine();
                int index = line.IndexOf(",");

                //Continue to read until you reach end of file
                while (line != null && line != "id;url;tags;")
                {
                    string id_string = (index > 0 ? line.Substring(0, index) : "");
                    id = Int32.Parse(id_string);
                    id++;

                    //write the lie to console window
                    Console.WriteLine(line);




                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Read database successfully.");
            }

            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("tagtasticdb.txt");

                //Write a line of text
                sw.WriteLine(id + ";" + url + ";" + tags + ";");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Added tags successfully.");
            }
        }

        public void counttags()
        {
            string line;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("tagtasticdb.txt");

                //string[] all_tags;
                List<string> all_tags = new List<string>();

                //Read the first line of text
                line = sr.ReadLine();
                //string[] tags_to_parse = list_to_parse[2].Split(',');

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //foreach (string tagname in tags_to_parse)
                    //{
                    //all_tags.Add(tagname);
                    //}

                    string[] line_to_parse = line.Split(';');
                    string[] tags_to_parse = line_to_parse[2].Split(',');

                    foreach (string tagname in tags_to_parse)
                    {
                        all_tags.Add(tagname);
                    }

                    //write the lie to console window
                    //Console.WriteLine(tagname);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();


                var res = from uniqueString
                in all_tags.Distinct(StringComparer.CurrentCultureIgnoreCase).ToList()
                          select new { str = uniqueString, occur = all_tags.Count(s => s.ToLower().Equals(uniqueString.ToLower())) };


                foreach (var el in res)
                {
                    Console.Write(el.GetType().GetProperty("str").GetValue(el, null) + "\t");
                    Console.WriteLine(el.GetType().GetProperty("occur").GetValue(el, null));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

    }

    class Slider
    {
        public string slider_js(string name)
        {
            string js_string = "<script type='text/javascript'>function showValue(newValue){document.getElementById('" + name + "').innerHTML=newValue;}</script>";
            return js_string;
        }

        public void slider_html(string name, string min, string max, string setting, string step)
        {
            Console.WriteLine("<label for='" + name + "'>" + name + "</label>");
            Console.WriteLine("<input type='range' id='" + name + "' min='" + min + "' max='" + max + "' value='" + setting + "' step='" + step + "' onchange='showValue(this.value)' />");
        }
    }

    class EssentialIcons
    {
        public void copy_icons(string icon_name, string project_name)
        {
            string sourcePath = AppDomain.CurrentDomain.BaseDirectory + "\\icons";
            string targetPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + project_name + "\\icons";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, icon_name + ".png");
            string destFile = System.IO.Path.Combine(targetPath, icon_name + ".png");

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public void icon_html(string icon_name, string height, string width)
        {
            Console.WriteLine("<img src='" + icon_name + ".png' height='" + height + "' width='" + width + "'>");
        }
    }


    class ImageGoRound
    {
        public void add_image(string imagename, string project_name)
        {
            string sourcePath = AppDomain.CurrentDomain.BaseDirectory + "\\images";
            string targetPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + project_name + "\\images";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, imagename + ".png");
            string destFile = System.IO.Path.Combine(targetPath, imagename + ".png");

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            //Write to text file

            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("imagelist.txt", true);

                //Write a line of text
                sw.WriteLine(imagename + ".png");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public string igr_css(string name)
        {
            string css_string = "#" + name + " .item{margin: 3px;} #" + name + " .item img{display: block;width: 100%;height: auto;}";
            return css_string;
        }

        public string igr_js(string name)
        {
            string js_string = "<script src='https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js'></script>";
            js_string += "<script>";
            js_string += "$(document).ready(function() {$('#" + name + "').owlCarousel({autoPlay: 3000, items : 4, itemsDesktop : [1199,3], itemsDesktopSmall : [979,3]});});";
            js_string += "</script>";
            return js_string;
        }

        public void igr_html(string name)
        {
            string line;

            Console.WriteLine("<div id='" + name + "'>");

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("imagelist.txt");
                List<string> ImageNames = new List<string>();


                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    ImageNames.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                //Console.ReadLine();

                foreach (string photo in ImageNames)
                {
                    Console.WriteLine("<div class='item'><img src='images//" + photo + "' alt='" + photo + "'></div>");
                }

                Console.WriteLine("</div>");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }

    class Notifications
    {

        public void notify_html(string button_name)
        {
            Console.WriteLine("<button onclick='notifyMe()'" + button_name + "</button>");
        }


        public string notify_js(string title, string tag, string icon_name, string project_name, string message)
        {
            EssentialIcons notify_icons = new EssentialIcons();
            notify_icons.copy_icons(icon_name, project_name);

            string icon_path = AppDomain.CurrentDomain.BaseDirectory + "\\" + project_name + "\\icons" + icon_name + ".png";

            string js_string = "<script>function notifyMe() {if (!('Notification' in window)) {alert('This browser does not support desktop notification');}";
            js_string += " else if (Notification.permission === 'granted') {var notification = new Notification('" + message + "', {icon: 'icons\\" + icon_name + ".png'});}";
            js_string += "  else if (Notification.permission !== 'denied') {Notification.requestPermission(function (permission) {if (permission === 'granted') {var notification = new Notification('" + message + "', {icon: '" + icon_name + ".png'});}});}";
            js_string += "</script>";

            return js_string;

        }
    }

    class ProgressBar
    {
        public void progress_html(string id, string max)
        {
            Console.WriteLine("<progress id='" + id + "' max='" + max + "'><span>0</span>%</progress>");
        }

        public string progress_js(string id, string max)
        {
            string js_string = "<script>var pBar = document.getElementById('" + id + "');var updateProgress = function(value) {pBar.value = value;pBar.getElementsByTagName('span')[0].innerHTML = Math.floor((100 / " + max + ") * value);}</script>";
            return js_string;
        }
    }

    class ToolTip
    {
        public void tooltip_html(string id, string caption, string text)
        {
            Console.WriteLine("<div class='" + id + "'>" + caption + "<span class='tooltiptext'>" + text + "</span></div>");
        }

        public string tooltip_js(string id)
        {
            string js_string = ".tooltip {position: relative;display: inline-block;border-bottom: 1px dotted black;}";
            js_string += ".tooltip .tooltiptext {visibility: hidden;width: 120px;background-color: #555;color: #fff;text-align: center;padding: 5px 0;border-radius: 6px;position: absolute;z-index: 1;bottom: 125%;left: 50%;margin-left: -60px;opacity: 0;transition: opacity 1s;}";
            js_string += ".tooltip .tooltiptext::after {content: \"\";position: absolute;top: 100%;left: 50%;margin-left: -5px;border-width: 5px;border-style: solid;border-color: #555 transparent transparent transparent;}";
            js_string += ".tooltip:hover .tooltiptext {visibility: visible;opacity: 1;}";

            return js_string;
        }
    }

    class MessageBox
    {
        public void messagebox_html(string text)
        {
            Console.WriteLine("<button onclick='myFunction()'>" + text + "</button>");

        }

        public string messagebox_js(string message)
        {
            string js_string = "<script>function myFunction() {alert('" + message + "');}</script>";

            return js_string;

        }
    }

    class Modal
    {
        public void modal_html(string button_name, string button_label, string modal_id, string modal_text)
        {
            Console.WriteLine("<button id='" + button_name + "'>" + button_label + "</button>");
            Console.WriteLine("<div id='" + modal_id + "' class='modal'>");
            Console.WriteLine("<div class='modal-content'>");
            Console.WriteLine("<span class='close'>x</span>");
            Console.WriteLine("<p>" + modal_text + "</p></div></div>");
        }

        public string modal_css()
        {
            string css_string = "<style>.modal {display: none;position: fixed;z-index: 1;left: 0;top: 0;width: 100%;height: 100%;overflow: auto;background-color: rgb(0,0,0);background-color: rgba(0,0,0,0.4);}";
            css_string += ".modal-content {background-color: #fefefe;margin: 15% auto; padding: 20px;border: 1px solid #888;width: 80%; }";
            css_string += ".close {color: #aaa;float: right;font-size: 28px;font-weight: bold;}";
            css_string += ".close:hover,.close:focus {color: black;text-decoration: none;cursor: pointer;}</style>";

            return css_string;

        }

        public string modal_js(string modal_id, string button_name)
        {
            string js_string = "var modal = document.getElementById('" + modal_id + "');";
            js_string += "var btn = document.getElementById('" + button_name + "');";
            js_string += "var span = document.getElementsByClassName('close')[0];";
            js_string += "btn.onclick = function() {modal.style.display = 'block';}";
            js_string += "span.onclick = function() {modal.style.display = 'none';}";
            js_string += "window.onclick = function(event) {if (event.target == modal) {modal.style.display = 'none';}}";

            return js_string;
        }
    }

    class Container
    {
        public void container_html(string section_names, string section_text)
        {
            string[] section_array = section_names.Split(';');
            string[] section_text_array = section_text.Split(';');
            int count = 0;

            foreach (string section in section_array)
            {
                Console.WriteLine("<button class='accordion'>" + section + "</button>");
                Console.WriteLine("<div class='panel'><p>" + section_text_array[count] + "</p></div>");
                count++;
            }
        }

        public string container_css()
        {
            string css_string = "button.accordion {background-color: #eee;color: #444;cursor: pointer;padding: 18px;width: 100%;text-align: left;border: none;outline: none;transition: 0.4s;}";
            css_string += "button.accordion.active, button.accordion:hover {background-color: #ddd;}";
            css_string += "div.panel {padding: 0 18px;background-color: white;display: none;}";
            css_string += "div.panel.show {display: block;}";

            return css_string;
        }

        public string container_js()
        {
            string js_string = "var acc = document.getElementsByClassName('accordion');var i;for (i = 0; i < acc.length; i++) {acc[i].onclick = function(){this.classList.toggle('active');this.nextElementSibling.classList.toggle('show');}}";

            return js_string;
        }
    }

    class HTMLElements
    {
        public void element_pick(int element)
        {

            switch (element)
            {
                case 1:
                    Console.Write("What is the heading? ");
                    string heading_text = Console.ReadLine();
                    heading(heading_text);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    Menu initial = new Menu();

                    string selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 2:
                    Console.Write("What is the paragraph? ");
                    string paragraph_text = Console.ReadLine();
                    paragraph(paragraph_text);

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 3:
                    linebreak();

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                case 4:
                    space();

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

                default:

                    Console.WriteLine("----------");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);

                    initial = new Menu();

                    selection = initial.main_menu();

                    initial.selection_switch(selection);

                    break;

            }


        }

        public void heading(string heading)
        {
            Console.WriteLine("<h>" + heading + "</h>");
        }

        public void paragraph(string content)
        {
            Console.WriteLine("<p>" + content + "</p>");
        }

        public void linebreak()
        {
            Console.WriteLine("<br>");
        }

        public void space()
        {
            Console.WriteLine("&nbsp");
        }
    }
}