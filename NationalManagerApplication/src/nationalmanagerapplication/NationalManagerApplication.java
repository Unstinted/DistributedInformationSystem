/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package nationalmanagerapplication;

import java.awt.Toolkit;
import javax.swing.JOptionPane;

/**
 *
 * @author dhammmie
 */
public class NationalManagerApplication extends javax.swing.JFrame {

    /**
     * Creates new form NationalManagerApplication
     */
    public NationalManagerApplication() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jMenuBar2 = new javax.swing.JMenuBar();
        jMenu2 = new javax.swing.JMenu();
        jMenu3 = new javax.swing.JMenu();
        jMenuItem1 = new javax.swing.JMenuItem();
        jMenuItem3 = new javax.swing.JMenuItem();
        jMenuItem4 = new javax.swing.JMenuItem();
        jMenu4 = new javax.swing.JMenu();
        JDesktopPane = new javax.swing.JDesktopPane();
        jMenuBar1 = new javax.swing.JMenuBar();
        Exit = new javax.swing.JMenu();
        ExitMenu = new javax.swing.JMenuItem();
        SetDiscount = new javax.swing.JMenu();
        jMenuItem2 = new javax.swing.JMenuItem();
        jMenu5 = new javax.swing.JMenu();
        MnViewRp = new javax.swing.JMenuItem();

        jMenu2.setText("File");
        jMenuBar2.add(jMenu2);

        jMenu3.setText("Edit");
        jMenuBar2.add(jMenu3);

        jMenuItem1.setText("jMenuItem1");

        jMenuItem3.setText("jMenuItem3");

        jMenuItem4.setText("jMenuItem4");

        jMenu4.setText("jMenu4");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().add(JDesktopPane, java.awt.BorderLayout.CENTER);

        Exit.setText("System");
        Exit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ExitActionPerformed(evt);
            }
        });

        ExitMenu.setText("Exit");
        ExitMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ExitMenuActionPerformed(evt);
            }
        });
        Exit.add(ExitMenu);

        jMenuBar1.add(Exit);

        SetDiscount.setText("SetDiscount");

        jMenuItem2.setText("SetNational Discount");
        jMenuItem2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItem2ActionPerformed(evt);
            }
        });
        SetDiscount.add(jMenuItem2);

        jMenuBar1.add(SetDiscount);

        jMenu5.setText("View Report");

        MnViewRp.setText("View Reports");
        MnViewRp.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                MnViewRpActionPerformed(evt);
            }
        });
        jMenu5.add(MnViewRp);

        jMenuBar1.add(jMenu5);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void ExitMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ExitMenuActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ExitMenuActionPerformed

    private void jMenuItem2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItem2ActionPerformed
// TODO add your handling code here:
        
        SetDiscount setDisc = new SetDiscount();
        setDisc.setVisible(true);
    }//GEN-LAST:event_jMenuItem2ActionPerformed

    private void ExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ExitActionPerformed
        // TODO add your handling code here:
        System.exit(0);
    }//GEN-LAST:event_ExitActionPerformed

    private void MnViewRpActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_MnViewRpActionPerformed
        // TODO add your handling code here:
        ViewReport vrp = new ViewReport();
        vrp.setVisible(true);
    }//GEN-LAST:event_MnViewRpActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /*
         * Set the Nimbus look and feel
         */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /*
         * If Nimbus (introduced in Java SE 6) is not available, stay with the
         * default look and feel. For details see
         * http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(NationalManagerApplication.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(NationalManagerApplication.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(NationalManagerApplication.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(NationalManagerApplication.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /*
         * Create and display the form
         */
        java.awt.EventQueue.invokeLater(new Runnable() {

            public void run() {
                FormLogin fmLogin = new FormLogin(null, true);
                fmLogin.setVisible(true);
                if(fmLogin.getReturnStatus() == fmLogin.RET_OK ){
                    String username = fmLogin.username;
                    String password = fmLogin.password;
                    int UserID = authenticates(username, password);
                    if (UserID != 0){
                        GlobalInfos.setUserID(UserID);
                        NationalManagerApplication na = new NationalManagerApplication();
                        Toolkit tk = Toolkit.getDefaultToolkit();
                        na.setSize(tk.getScreenSize());
                        na.setVisible(true);
                    }else{
                        JOptionPane.showMessageDialog(fmLogin, "Invalid Login");
                    }
                    
                }else{
                    System.exit(0);
                }
                
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenu Exit;
    private javax.swing.JMenuItem ExitMenu;
    private javax.swing.JDesktopPane JDesktopPane;
    private javax.swing.JMenuItem MnViewRp;
    private javax.swing.JMenu SetDiscount;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenu jMenu3;
    private javax.swing.JMenu jMenu4;
    private javax.swing.JMenu jMenu5;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuBar jMenuBar2;
    private javax.swing.JMenuItem jMenuItem1;
    private javax.swing.JMenuItem jMenuItem2;
    private javax.swing.JMenuItem jMenuItem3;
    private javax.swing.JMenuItem jMenuItem4;
    // End of variables declaration//GEN-END:variables

    private static int authenticates(java.lang.String username, java.lang.String password) {
        org.tempuri.NationalManagerService service = new org.tempuri.NationalManagerService();
        org.tempuri.NationalManagerServiceSoap port = service.getNationalManagerServiceSoap();
        return port.authenticates(username, password);
    }
}
